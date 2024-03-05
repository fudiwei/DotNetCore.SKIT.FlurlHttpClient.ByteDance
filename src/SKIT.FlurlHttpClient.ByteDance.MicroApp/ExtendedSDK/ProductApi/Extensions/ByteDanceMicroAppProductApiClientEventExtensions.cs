using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi
{
    /// <summary>
    /// 为 <see cref="ByteDanceMicroAppProductApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class ByteDanceMicroAppProductApiClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppProductApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this ByteDanceMicroAppProductApiClient client, string webhookJson)
            where TEvent : ByteDanceMicroAppProductApiEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppProductApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static ByteDanceMicroAppProductApiEvent DeserializeEventFromJson(this ByteDanceMicroAppProductApiClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<ByteDanceMicroAppProductApiEvent>(client, webhookJson);
        }
    }

    partial class ByteDanceMicroAppProductApiClientEventExtensions
    {
        private static TEvent InnerDeserializeEventFromJson<TEvent>(ByteDanceMicroAppProductApiClient client, string webhookJson)
            where TEvent : ByteDanceMicroAppProductApiEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (Exception ex)
            {
                throw new ByteDanceMicroAppException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
