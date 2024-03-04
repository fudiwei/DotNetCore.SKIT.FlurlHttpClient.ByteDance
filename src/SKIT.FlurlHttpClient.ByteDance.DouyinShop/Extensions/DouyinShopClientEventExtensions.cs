using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop
{
    /// <summary>
    /// 为 <see cref="DouyinShopClient"/> 提供消息推送事件的扩展方法。
    /// </summary>
    public static class DouyinShopClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinShopEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEvent<TEvent>(this DouyinShopClient client, string callbackJson)
            where TEvent : DouyinShopEvent, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DouyinShopEventSerializationException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinShopEvent"/> 对象数组。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent[] DeserializeEvents<TEvent>(this DouyinShopClient client, string callbackJson)
            where TEvent : DouyinShopEvent, new()
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent[]>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.DouyinShopEventSerializationException("Failed to deserialize event. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>验证消息推送事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://op.jinritemai.com/docs/guide-docs/153/99 ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson">抖店回调通知中请求正文（JSON 格式）。</param>
        /// <param name="callbackSignature">抖店回调通知中的 "event-sign" 请求标头。</param>
        /// <returns></returns>
        public static bool VerifyEventSignature(this DouyinShopClient client, string callbackJson, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                Utilities.JsonUtility.Format(callbackJson); // 验证是否是有效的 JSON

                string plainText = $"{client.Credentials.AppKey}{callbackJson}{client.Credentials.AppSecret}";
                string signText = Utilities.MD5Utility.Hash(plainText);
                return string.Equals(signText, callbackSignature, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }
}
