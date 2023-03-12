using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi
{
    /// <summary>
    /// 为 <see cref="ByteDanceMicroAppProductApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class ByteDanceMicroAppProductApiClientEventExtensions
    {
        private static TEvent InnerDeserializeEventFromJson<TEvent>(ByteDanceMicroAppProductApiClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppProductApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppProductApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this ByteDanceMicroAppProductApiClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppProductApiEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppProductApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static ByteDanceMicroAppProductApiEvent DeserializeEventFromJson(this ByteDanceMicroAppProductApiClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<ByteDanceMicroAppProductApiEvent>(client, callbackJson);
        }
    }
}
