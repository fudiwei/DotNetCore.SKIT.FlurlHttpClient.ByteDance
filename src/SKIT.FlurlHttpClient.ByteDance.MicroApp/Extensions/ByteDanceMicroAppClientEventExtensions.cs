using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 为 <see cref="ByteDanceMicroAppClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class ByteDanceMicroAppClientEventExtensions
    {
        public static TEvent DeserializeEventFromJson<TEvent>(this ByteDanceMicroAppClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (Exception ex)
            {
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        public static TEvent DeserializeEventFromXml<TEvent>(this ByteDanceMicroAppClient client, string callbackXml)
            where TEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IXmlSerializable
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackXml)) throw new ArgumentNullException(callbackXml);

            try
            {
                using var reader = new StringReader(callbackXml);

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(TEvent), new XmlRootAttribute("xml"));
                return (TEvent)xmlSerializer.Deserialize(reader)!;
            }
            catch (Exception ex)
            {
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Deserialize event failed. Please see the `InnerException` for more details.", ex);
            }
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://microapp.bytedance.com/docs/zh-CN/mini-app/develop/component/message-push-customer-service </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">头条回调通知中的 timestamp 字段。</param>
        /// <param name="callbackNonce">头条回调通知中的 nonce 字段。</param>
        /// <param name="callbackMessage">头条回调通知中的 msg 字段。</param>
        /// <param name="callbackSignature">头条回调通知中的 signature 字段。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this ByteDanceMicroAppClient client, string callbackTimestamp, string callbackNonce, string callbackMessage, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackMessage == null) throw new ArgumentNullException(nameof(callbackMessage));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            ISet<string> set = new SortedSet<string>(StringComparer.Ordinal) { client.Credentials.PushToken!, callbackTimestamp, callbackNonce, callbackMessage };
            string sign = Security.SHA1Utility.Hash(string.Concat(set));
            return string.Equals(sign, callbackSignature, StringComparison.InvariantCultureIgnoreCase);
        }

    }
}
