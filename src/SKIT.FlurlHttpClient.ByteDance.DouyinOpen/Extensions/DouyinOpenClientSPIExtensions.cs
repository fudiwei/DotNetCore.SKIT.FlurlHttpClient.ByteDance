using System;
using System.Text;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    public static class DouyinOpenClientSPIExtensions
    {
        /// <summary>
        /// <para>验证 SPI 接口签名。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/beforeinsert/signruleintroduce/ </para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/beforeinsert/signruleintroduce/ </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="requestTimestamp">抖音 SPI 接口中的 timestamp 查询参数。</param>
        /// <param name="requestBody">抖音 SPI 接口中请求正文。</param>
        /// <param name="requestSignature">抖音 SPI 接口中的 X-Life-Sign 请求标头。</param>
        /// <returns></returns>
        public static bool VerifySPIRequestSignature(this DouyinOpenClient client, string requestTimestamp, string requestBody, string requestSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (requestBody == null) throw new ArgumentNullException(nameof(requestBody));

            try
            {
                string plainText = $"{client.Credentials.ClientSecret}&client_key={client.Credentials.ClientKey}&timestamp={requestTimestamp}";
                if (!string.IsNullOrEmpty(requestBody))
                    plainText += $"&http_body={requestBody}";

                string signText = Utilities.SHA256Utility.Hash(plainText);
                return string.Equals(signText, requestSignature, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 解密 SPI 接口中的敏感字段。
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/beforeinsert/decrypt </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="encodingCipherText">经 Base64 编码后的待解密数据。</param>
        /// <returns>解密后的数据。</returns>
        public static string DecryptSPICipherField(this DouyinOpenClient client, string encodingCipherText)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (encodingCipherText == null) throw new ArgumentNullException(encodingCipherText);

            const int KEY_SIZE = 32;
            const int KEY_IV_OFFSET = 16;
            string key = client.Credentials.ClientSecret ?? string.Empty;

            // 不足位填充
            if (key.Length < KEY_SIZE)
            {
                int r = (KEY_SIZE - key.Length) / 2;
                int l = (KEY_SIZE - key.Length) - r;

                key = key.PadRight(key.Length + r, '#');
                key = key.PadLeft(key.Length + l, '#');
            }

            // 溢出位截断
            if (key.Length > KEY_SIZE)
            {
                int r = (key.Length - KEY_SIZE) / 2;
                int l = (key.Length - KEY_SIZE) - r;

                return key.Substring(l, KEY_SIZE + l);
            }

            byte[] keyBytes = Encoding.UTF8.GetBytes(key);
            byte[] ivBytes = Encoding.UTF8.GetBytes(key.Substring(KEY_IV_OFFSET));
            byte[] cipherBytes = Convert.FromBase64String(encodingCipherText);
            byte[] plainBytes = Utilities.AESUtility.DecryptWithCBC(keyBytes, ivBytes, cipherBytes);
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
