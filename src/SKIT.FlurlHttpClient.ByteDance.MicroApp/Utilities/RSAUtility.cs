using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// RSA 算法工具类。
    /// </summary>
    public static class RSAUtility
    {
        /// <summary>
        /// 签名算法：SHA-256withRSA。
        /// </summary>
        private const string DIGEST_ALGORITHM_SHA256 = "SHA-256withRSA";

        private static byte[] ConvertPrivateKeyPemToByteArray(string privateKeyPem)
        {
            const string PKCS8_HEADER = "-----BEGIN PRIVATE KEY-----";
            const string PKCS8_FOOTER = "-----END PRIVATE KEY-----";

            if (!privateKeyPem.StartsWith(PKCS8_HEADER))
            {
                using (TextReader textReader = new StringReader(privateKeyPem))
                using (PemReader pemReader = new PemReader(textReader))
                {
                    object pemObject = pemReader.ReadObject();

                    if (pemObject is AsymmetricCipherKeyPair)
                    {
                        // PKCS#1 格式
                        AsymmetricCipherKeyPair cipherKeyPair = (AsymmetricCipherKeyPair)pemObject;
                        using (TextWriter textWriter = new StringWriter())
                        using (PemWriter pemWriter = new PemWriter(textWriter))
                        {
                            Pkcs8Generator pkcs8 = new Pkcs8Generator(cipherKeyPair.Private);
                            pemWriter.WriteObject(pkcs8);
                            pemWriter.Writer.Close();

                            privateKeyPem = textWriter.ToString()!;
                        }
                    }
                    else if (pemObject is RsaPrivateCrtKeyParameters)
                    {
                        // PKCS#8 格式
                    }
                    else
                    {
                        throw new NotSupportedException("Private key format is not supported.");
                    }
                }
            }

            privateKeyPem = privateKeyPem
                .Replace(PKCS8_HEADER, string.Empty)
                .Replace(PKCS8_FOOTER, string.Empty);
            privateKeyPem = Regex.Replace(privateKeyPem, "\\s+", string.Empty);
            return Convert.FromBase64String(privateKeyPem);
        }

        private static byte[] ConvertPublicKeyPemToByteArray(string publicKeyPem)
        {
            const string PKCS8_HEADER = "-----BEGIN PUBLIC KEY-----";
            const string PKCS8_FOOTER = "-----END PUBLIC KEY-----";

            if (!publicKeyPem.StartsWith(PKCS8_HEADER))
            {
                using (TextReader textReader = new StringReader(publicKeyPem))
                using (PemReader pemReader = new PemReader(textReader))
                {
                    object pemObject = pemReader.ReadObject();
                    if (pemObject is RsaKeyParameters)
                    {
                        // PKCS#1 或 PKCS#8 格式
                        RsaKeyParameters rsaKeyParams = (RsaKeyParameters)pemObject;
                        using (TextWriter textWriter = new StringWriter())
                        using (PemWriter pemWriter = new PemWriter(textWriter))
                        {
                            pemWriter.WriteObject(rsaKeyParams);
                            pemWriter.Writer.Close();

                            publicKeyPem = textWriter.ToString()!;
                        }
                    }
                    else
                    {
                        throw new NotSupportedException("Public key format is not supported.");
                    }
                }
            }

            publicKeyPem = publicKeyPem
                .Replace(PKCS8_HEADER, string.Empty)
                .Replace(PKCS8_FOOTER, string.Empty);
            publicKeyPem = Regex.Replace(publicKeyPem, "\\s+", string.Empty);
            return Convert.FromBase64String(publicKeyPem);
        }

#if NET5_0_OR_GREATER
#else
        private static RsaKeyParameters ParsePrivateKeyToParameters(byte[] privateKeyBytes)
        {
            return (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
        }

        private static RsaKeyParameters ParsePublicKeyToParameters(byte[] publicKeyBytes)
        {
            return (RsaKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
        }

        private static byte[] Sign(RsaKeyParameters rsaPrivateKeyParams, byte[] messageBytes, string algorithm)
        {
            ISigner signer = SignerUtilities.GetSigner(algorithm);
            signer.Init(true, rsaPrivateKeyParams);
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);
            return signer.GenerateSignature();
        }

        private static bool Verify(RsaKeyParameters rsaPublicKeyParams, byte[] messageBytes, byte[] signBytes, string algorithm)
        {
            ISigner signer = SignerUtilities.GetSigner(algorithm);
            signer.Init(false, rsaPublicKeyParams);
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);
            return signer.VerifySignature(signBytes);
        }
#endif

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSHA256(byte[] privateKeyBytes, byte[] messageBytes)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

#if NET5_0_OR_GREATER
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);
                return rsa.SignData(messageBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
#else
            RsaKeyParameters rsaPrivateKeyParams = ParsePrivateKeyToParameters(privateKeyBytes);
            return Sign(rsaPrivateKeyParams, messageBytes, DIGEST_ALGORITHM_SHA256);
#endif
        }

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#1/PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="messageData">待签名的数据。</param>
        /// <returns>经过 Base64 编码的签名。</returns>
        public static EncodedString SignWithSHA256(string privateKeyPem, string messageData)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] privateKeyBytes = ConvertPrivateKeyPemToByteArray(privateKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = SignWithSHA256(privateKeyBytes, messageBytes);
            return EncodedString.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(byte[] publicKeyBytes, byte[] messageBytes, byte[] signBytes)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));
            if (signBytes is null) throw new ArgumentNullException(nameof(signBytes));

#if NET5_0_OR_GREATER
            using (RSA rsa = RSA.Create())
            {
                rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);
                return rsa.VerifyData(messageBytes, signBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
            }
#else
            RsaKeyParameters rsaPublicKeyParams = ParsePublicKeyToParameters(publicKeyBytes);
            return Verify(rsaPublicKeyParams, messageBytes, signBytes, DIGEST_ALGORITHM_SHA256);
#endif
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#1/PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(string publicKeyPem, string messageData, EncodedString encodingSignature)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));
            if (encodingSignature.Value is null) throw new ArgumentNullException(nameof(encodingSignature));

            byte[] publicKeyBytes = ConvertPublicKeyPemToByteArray(publicKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64);
            return VerifyWithSHA256(publicKeyBytes, messageBytes, signBytes);
        }
    }
}
