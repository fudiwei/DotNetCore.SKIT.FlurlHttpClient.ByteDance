using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen
{
    /// <summary>
    /// 为 <see cref="DouyinOpenClient"/> 提供 Webhook 事件的扩展方法。
    /// </summary>
    public static class DouyinOpenClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinOpenEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this DouyinOpenClient client, string callbackJson)
            where TEvent : DouyinOpenEvent, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DouyinOpenEventSerializationException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>验证 Webhook 事件签名。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/summarize </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson">抖音 Webhook 事件中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">抖音 Webhook 事件中的 "X-Douyin-Signature" 请求标头。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this DouyinOpenClient client, string callbackJson, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                string plainText = $"{client.Credentials.ClientSecret}{callbackJson}";
                string signText = Utilities.SHA1Utility.Hash(plainText);
                return string.Equals(signText, callbackSignature, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }
}
