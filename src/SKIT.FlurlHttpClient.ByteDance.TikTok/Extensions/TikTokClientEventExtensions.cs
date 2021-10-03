using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

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
    }
}
