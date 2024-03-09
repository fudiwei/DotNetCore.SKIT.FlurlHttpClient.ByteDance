using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    /// <summary>
    /// 为 <see cref="DouyinMicroAppProductApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class DouyinMicroAppProductApiClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinMicroAppProductApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this DouyinMicroAppProductApiClient client, string webhookJson)
            where TEvent : DouyinMicroAppProductApiEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinMicroAppProductApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static DouyinMicroAppProductApiEvent DeserializeEventFromJson(this DouyinMicroAppProductApiClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<DouyinMicroAppProductApiEvent>(client, webhookJson);
        }
    }

    partial class DouyinMicroAppProductApiClientEventExtensions
    {
        private static TEvent InnerDeserializeEventFromJson<TEvent>(DouyinMicroAppProductApiClient client, string webhookJson)
            where TEvent : DouyinMicroAppProductApiEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (Exception ex)
            {
                throw new DouyinMicroAppException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
