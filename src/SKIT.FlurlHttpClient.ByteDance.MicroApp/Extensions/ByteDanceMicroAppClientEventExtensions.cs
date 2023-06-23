using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    /// <summary>
    /// 为 <see cref="ByteDanceMicroAppClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class ByteDanceMicroAppClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            [System.Xml.Serialization.XmlElement("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
            [System.Xml.Serialization.XmlElement("TimeStamp")]
            public string TimestampString { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("Nonce")]
            [System.Text.Json.Serialization.JsonPropertyName("Nonce")]
            [System.Xml.Serialization.XmlElement("Nonce")]
            public string Nonce { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("MsgSignature")]
            [System.Text.Json.Serialization.JsonPropertyName("MsgSignature")]
            [System.Xml.Serialization.XmlElement("MsgSignature")]
            public string Signature { get; set; } = default!;
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(ByteDanceMicroAppClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(callbackJson);

            try
            {
                if (callbackJson.Contains("\"Encrypt\""))
                {
                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                    callbackJson = Utilities.TtMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return client.JsonSerializer.Deserialize<TEvent>(callbackJson);
            }
            catch (ByteDanceMicroAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(ByteDanceMicroAppClient client, string callbackXml)
            where TEvent : ByteDanceMicroAppEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(callbackXml);

            try
            {
                if (callbackXml.Contains("<Encrypt>") && callbackXml.Contains("</Encrypt>"))
                {
                    string encryptedData = XDocument.Parse(callbackXml).Root!.Element("Encrypt")!.Value;
                    callbackXml = Utilities.TtMsgCryptor.AESDecrypt(cipherText: encryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return Utilities.XmlUtility.Deserialize<TEvent>(callbackXml);
            }
            catch (ByteDanceMicroAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this ByteDanceMicroAppClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IJsonSerializable, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static ByteDanceMicroAppEvent DeserializeEventFromJson(this ByteDanceMicroAppClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<ByteDanceMicroAppEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="ByteDanceMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this ByteDanceMicroAppClient client, string callbackXml)
            where TEvent : ByteDanceMicroAppEvent, ByteDanceMicroAppEvent.Serialization.IXmlSerializable, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="ByteDanceMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static ByteDanceMicroAppEvent DeserializeEventFromXml(this ByteDanceMicroAppClient client, string callbackXml)
        {
            return InnerDeserializeEventFromXml<ByteDanceMicroAppEvent>(client, callbackXml);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/component/message-push-customer-service </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackTimestamp">头条回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="callbackNonce">头条回调通知中的 "nonce" 查询参数。</param>
        /// <param name="callbackMessage">头条回调通知中的 "msg" 查询参数。</param>
        /// <param name="callbackSignature">头条回调通知中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static bool VerifyEventSignatureForEcho(this ByteDanceMicroAppClient client, string callbackTimestamp, string callbackNonce, string callbackMessage, string callbackSignature)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackTimestamp == null) throw new ArgumentNullException(nameof(callbackTimestamp));
            if (callbackNonce == null) throw new ArgumentNullException(nameof(callbackNonce));
            if (callbackMessage == null) throw new ArgumentNullException(nameof(callbackMessage));
            if (callbackSignature == null) throw new ArgumentNullException(nameof(callbackSignature));

            List<string> lstParams = new List<string>() { client.Credentials.PushToken!, callbackTimestamp, callbackNonce, callbackMessage };
            lstParams.Sort(StringComparer.Ordinal);

            string sign = Utilities.SHA1Utility.Hash(string.Concat(lstParams));
            return string.Equals(sign, callbackSignature, StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromJson(this ByteDanceMicroAppClient client, string callbackJson)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                return Utilities.TtMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: encryptedEvent.TimestampString,
                    sNonce: encryptedEvent.Nonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: encryptedEvent.Signature
                );
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackXml"></param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromXml(this ByteDanceMicroAppClient client, string callbackXml)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackXml == null) throw new ArgumentNullException(nameof(callbackXml));

            try
            {
                XDocument xdoc = XDocument.Parse(callbackXml);
                return Utilities.TtMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: xdoc.Root!.Element("TimeStamp")!.Value,
                    sNonce: xdoc.Root!.Element("Nonce")!.Value,
                    sMsgEncrypt: xdoc.Root!.Element("Encrypt")!.Value,
                    sMsgSign: xdoc.Root!.Element("MsgSignature")!.Value
                );
            }
            catch
            {
                return false;
            }
        }
    }
}
