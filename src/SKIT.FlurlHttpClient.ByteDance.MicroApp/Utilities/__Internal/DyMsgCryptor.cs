using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Utilities
{
    internal static class DyMsgCryptor
    {
        private const int AES_KEY_SIZE = 256;
        private const int AES_BLOCK_SIZE = 128;

        private static byte[] Decode2(byte[] decryptedBytes)
        {
            if (decryptedBytes is null) throw new ArgumentNullException(nameof(decryptedBytes));

            int pad = (int)decryptedBytes[decryptedBytes.Length - 1];
            if (pad < 1 || pad > 32)
            {
                pad = 0;
            }

            byte[] res = new byte[decryptedBytes.Length - pad];
            Array.Copy(decryptedBytes, 0, res, 0, decryptedBytes.Length - pad);
            return res;
        }

        private static byte[] AESDecrypt(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes is null) throw new ArgumentNullException(nameof(ivBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            using var aes = Aes.Create();
            aes.KeySize = AES_KEY_SIZE;
            aes.BlockSize = AES_BLOCK_SIZE;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.None;
            aes.Key = keyBytes;
            aes.IV = ivBytes;

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            using (var ms = new MemoryStream())
            using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write))
            {
                byte[] msgBytes = new byte[cipherBytes.Length + 32 - cipherBytes.Length % 32];
                Array.Copy(cipherBytes, msgBytes, cipherBytes.Length);
                cs.Write(cipherBytes, 0, cipherBytes.Length);

                byte[] plainBytes = Decode2(ms.ToArray());
                return plainBytes;
            }
        }

        public static string AESDecrypt(string cipherText, string encodingAESKey, out string appId)
        {
            if (cipherText is null) throw new ArgumentNullException(nameof(cipherText));
            if (encodingAESKey is null) throw new ArgumentNullException(nameof(encodingAESKey));

            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Convert.FromBase64String(encodingAESKey + "=");
            byte[] ivBytes = new byte[16];
            Array.Copy(keyBytes, ivBytes, 16);
            byte[] btmpMsg = AESDecrypt(cipherBytes: cipherBytes, ivBytes: ivBytes, keyBytes: keyBytes);

            int len = BitConverter.ToInt32(btmpMsg, 32);
            len = IPAddress.NetworkToHostOrder(len);

            byte[] bMsg = new byte[len];
            byte[] bAppId = new byte[btmpMsg.Length - 36 - len];
            Array.Copy(btmpMsg, 36, bMsg, 0, len);
            Array.Copy(btmpMsg, 36 + len, bAppId, 0, bAppId.Length);

            appId = Encoding.UTF8.GetString(bAppId);
            return Encoding.UTF8.GetString(bMsg);
        }

        public static bool VerifySignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt, string sMsgSign)
        {
            if (sToken is null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp is null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce is null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt is null) throw new ArgumentNullException(nameof(sMsgEncrypt));
            if (sMsgSign is null) throw new ArgumentNullException(nameof(sMsgSign));

            string expectedSign = GenerateSignature(sToken, sTimestamp, sNonce, sMsgEncrypt);
            return string.Equals(expectedSign, sMsgSign, StringComparison.OrdinalIgnoreCase);
        }

        public static string GenerateSignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt)
        {
            if (sToken is null) throw new ArgumentNullException(nameof(sToken));
            if (sTimestamp is null) throw new ArgumentNullException(nameof(sTimestamp));
            if (sNonce is null) throw new ArgumentNullException(nameof(sNonce));
            if (sMsgEncrypt is null) throw new ArgumentNullException(nameof(sMsgEncrypt));

            List<string> tmp = new List<string>(capacity: 4) { sToken, sTimestamp, sNonce, sMsgEncrypt };
            tmp.Sort(StringComparer.Ordinal);

            string rawText = string.Concat(tmp);
            string signText = SHA1Utility.Hash(rawText).Value!;
            return signText.ToLower();
        }

        public static bool TryParseXml(string xml, out string encryptedMsg)
        {
            if (xml is null) throw new ArgumentNullException(nameof(xml));

            encryptedMsg = string.Empty;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.XmlResolver = null!;
                xmlDoc.LoadXml(xml);

                XmlNode? xmlRoot = xmlDoc.FirstChild;
                if (xmlRoot is null)
                    return false;

                encryptedMsg = xmlRoot["Encrypt"]?.InnerText?.ToString() ?? string.Empty;

                return !string.IsNullOrEmpty(encryptedMsg);
            }
            catch (XmlException)
            {
                return false;
            }
        }
    }
}
