using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    /// <summary>
    /// 为 <see cref="TikTokClient"/> 提供 Webhook 事件的扩展方法。
    /// </summary>
    public static class TikTokClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="TikTokEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this TikTokClient client, string callbackJson)
            where TEvent : TikTokEvent, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.TikTokEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>验证 Webhook 事件签名。</para>
        /// <para>REF: https://open.douyin.com/platform/doc?doc=docs/develop/webhooks/summarize </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson">抖音 Webhook 事件中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">抖音 Webhook 事件中的 X-Douyin-Signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this TikTokClient client, string callbackJson, string callbackSignature)
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
