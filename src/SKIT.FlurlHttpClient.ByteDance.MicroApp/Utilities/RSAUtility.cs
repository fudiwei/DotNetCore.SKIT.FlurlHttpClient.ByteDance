using System;
using System.IO;
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
        public const string DIGEST_ALGORITHM_SHA256 = "SHA-256withRSA";

        private static byte[] ConvertPrivateKeyPemToByteArray(string privateKeyPem)
        {
            if (!privateKeyPem.StartsWith("-----BEGIN PRIVATE KEY-----"))
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
                .Replace("-----BEGIN PRIVATE KEY-----", string.Empty)
                .Replace("-----END PRIVATE KEY-----", string.Empty);
            privateKeyPem = Regex.Replace(privateKeyPem, "\\s+", string.Empty);
            return Convert.FromBase64String(privateKeyPem);
        }

        private static byte[] ConvertPublicKeyPemToByteArray(string publicKeyPem)
        {
            if (!publicKeyPem.StartsWith("-----BEGIN PUBLIC KEY-----"))
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
                .Replace("-----BEGIN PUBLIC KEY-----", string.Empty)
                .Replace("-----END PUBLIC KEY-----", string.Empty);
            publicKeyPem = Regex.Replace(publicKeyPem, "\\s+", string.Empty);
            return Convert.FromBase64String(publicKeyPem);
        }

        private static RsaKeyParameters ParsePrivateKeyToParameters(byte[] privateKeyBytes)
        {
            return (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
        }

        private static RsaKeyParameters ParsePublicKeyToParameters(byte[] publicKeyBytes)
        {
            return (RsaKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
        }

        private static byte[] Sign(RsaKeyParameters rsaPrivateKeyParams, byte[] messageBytes, string digestAlgorithm)
        {
            ISigner signer = SignerUtilities.GetSigner(digestAlgorithm);
            signer.Init(true, rsaPrivateKeyParams);
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);
            return signer.GenerateSignature();
        }

        private static bool Verify(RsaKeyParameters rsaPublicKeyParams, byte[] messageBytes, byte[] signBytes, string digestAlgorithm)
        {
            ISigner signer = SignerUtilities.GetSigner(digestAlgorithm);
            signer.Init(false, rsaPublicKeyParams);
            signer.BlockUpdate(messageBytes, 0, messageBytes.Length);
            return signer.VerifySignature(signBytes);
        }

        /// <summary>
        /// 使用私钥生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#1/PKCS#8 私钥字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <param name="digestAlgorithm">签名算法。（默认值：<see cref="DIGEST_ALGORITHM_SHA256"/>）</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] Sign(byte[] privateKeyBytes, byte[] messageBytes, string digestAlgorithm = DIGEST_ALGORITHM_SHA256)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            RsaKeyParameters rsaPrivateKeyParams = ParsePrivateKeyToParameters(privateKeyBytes);
            return Sign(rsaPrivateKeyParams, messageBytes, digestAlgorithm);
        }

        /// <summary>
        /// 使用私钥生成签名。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#1/PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="messageData">待签名的数据。</param>
        /// <param name="digestAlgorithm">签名算法。（默认值：<see cref="DIGEST_ALGORITHM_SHA256"/>）</param>
        /// <returns>经过 Base64 编码的签名。</returns>
        public static EncodedString Sign(string privateKeyPem, string messageData, string digestAlgorithm = DIGEST_ALGORITHM_SHA256)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] privateKeyBytes = ConvertPrivateKeyPemToByteArray(privateKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = Sign(privateKeyBytes, messageBytes, digestAlgorithm);
            return EncodedString.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#1/PKCS#8 公钥字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <param name="digestAlgorithm">签名算法。（默认值：<see cref="DIGEST_ALGORITHM_SHA256"/>）</param>
        /// <returns>验证结果。</returns>
        public static bool Verify(byte[] publicKeyBytes, byte[] messageBytes, byte[] signBytes, string digestAlgorithm = DIGEST_ALGORITHM_SHA256)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));
            if (signBytes is null) throw new ArgumentNullException(nameof(signBytes));

            RsaKeyParameters rsaPublicKeyParams = ParsePublicKeyToParameters(publicKeyBytes);
            return Verify(rsaPublicKeyParams, messageBytes, signBytes, digestAlgorithm);
        }

        /// <summary>
        /// 使用公钥验证签名。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#1/PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <param name="digestAlgorithm">签名算法。（默认值：<see cref="DIGEST_ALGORITHM_SHA256"/>）</param>
        /// <returns>验证结果。</returns>
        public static bool Verify(string publicKeyPem, string messageData, EncodedString encodingSignature, string digestAlgorithm = DIGEST_ALGORITHM_SHA256)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));
            if (encodingSignature.Value is null) throw new ArgumentNullException(nameof(encodingSignature));

            byte[] publicKeyBytes = ConvertPublicKeyPemToByteArray(publicKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64);
            return Verify(publicKeyBytes, messageBytes, signBytes, digestAlgorithm);
        }
    }
}
