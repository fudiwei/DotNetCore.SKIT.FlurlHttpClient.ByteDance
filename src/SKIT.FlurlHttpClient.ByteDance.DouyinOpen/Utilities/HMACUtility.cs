using System;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Utilities
{
    /// <summary>
    /// HMAC 算法工具类。
    /// </summary>
    public static class HMACUtility
    {
        /// <summary>
        /// 获取 HMAC-SHA-256 消息认证码。
        /// </summary>
        /// <param name="secretBytes">密钥字节数组。</param>
        /// <param name="msgbytes">信息字节数组。</param>
        /// <returns>消息认证码字节数组。</returns>
        public static byte[] HashWithSHA256(byte[] secretBytes, byte[] msgbytes)
        {
            if (secretBytes == null) throw new ArgumentNullException(nameof(secretBytes));
            if (msgbytes == null) throw new ArgumentNullException(nameof(msgbytes));

            using HMAC hmac = new HMACSHA256(secretBytes);
            return hmac.ComputeHash(msgbytes);
        }

        /// <summary>
        /// 获取 HMAC-SHA-256 消息认证码。
        /// </summary>
        /// <param name="secret">密钥。</param>
        /// <param name="message">文本信息。</param>
        /// <returns>消息认证码。</returns>
        public static string HashWithSHA256(string secret, string message)
        {
            if (secret == null) throw new ArgumentNullException(nameof(secret));
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] secretBytes = Encoding.UTF8.GetBytes(secret);
            byte[] msgbytes = Encoding.UTF8.GetBytes(message);
            byte[] hashBytes = HashWithSHA256(secretBytes, msgbytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }
}
