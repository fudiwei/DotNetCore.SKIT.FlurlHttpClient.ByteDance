using System;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    /// <summary>
    /// 为 <see cref="DouyinOpenClient"/> 提供解密的扩展方法。
    /// </summary>
    public static class DouyinOpenClientDecryptionExtensions
    {
        /// <summary>
        /// 解密用户公开信息中的手机号码。
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-management/phone-number-decode-demo </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="encryptedMobileNumber"></param>
        /// <returns></returns>
        public static string DecryptOAuthUserInfoMobileNumber(this DouyinOpenClient client, string encryptedMobileNumber)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (encryptedMobileNumber == null) throw new ArgumentNullException(encryptedMobileNumber);

            byte[] keyBytes = Encoding.UTF8.GetBytes(client.Credentials.ClientSecret);
            byte[] ivBytes = new byte[16]; Array.Copy(keyBytes, 0, ivBytes, 0, 16);
            byte[] cipherBytes = Convert.FromBase64String(encryptedMobileNumber);
            byte[] plainBytes = Utilities.AESUtility.DecryptWithCBC(keyBytes, ivBytes, cipherBytes);
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
