using System;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    /// <summary>
    /// 为 <see cref="TikTokClient"/> 提供解密的扩展方法。
    /// </summary>
    public static class TikTokClientDecryptionExtensions
    {
        /// <summary>
        /// 解密手机号码。
        /// </summary>
        /// <param name="client"></param>
        /// <param name="encryptedMobileNumber"></param>
        /// <returns></returns>
        public static string DecryptMobileNumber(this TikTokClient client, string encryptedMobileNumber)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(encryptedMobileNumber)) throw new ArgumentNullException(encryptedMobileNumber);

            byte[] keyBytes = Encoding.UTF8.GetBytes(client.Credentials.ClientSecret);
            byte[] ivBytes = new byte[16]; Array.Copy(keyBytes, 0, ivBytes, 0, 16);
            byte[] cipherBytes = Convert.FromBase64String(encryptedMobileNumber);
            byte[] plainBytes = Utilities.AESUtility.DecryptWithCBC(keyBytes, ivBytes, cipherBytes);
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
