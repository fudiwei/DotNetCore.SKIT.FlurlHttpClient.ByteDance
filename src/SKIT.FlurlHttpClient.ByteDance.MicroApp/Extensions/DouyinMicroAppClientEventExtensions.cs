using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="DouyinMicroAppClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class DouyinMicroAppClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this DouyinMicroAppClient client, string webhookJson)
            where TEvent : DouyinMicroAppEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static DouyinMicroAppEvent DeserializeEventFromJson(this DouyinMicroAppClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<DouyinMicroAppEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="DouyinMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this DouyinMicroAppClient client, string webhookXml)
            where TEvent : DouyinMicroAppEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="DouyinMicroAppEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static DouyinMicroAppEvent DeserializeEventFromXml(this DouyinMicroAppClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<DouyinMicroAppEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/component/message-push-customer-service ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookTimestamp">头条回调通知中的 "timestamp" 查询参数。</param>
        /// <param name="webhookNonce">头条回调通知中的 "nonce" 查询参数。</param>
        /// <param name="webhookMsg">头条回调通知中的 "msg" 查询参数。</param>
        /// <param name="webhookSignature">头条回调通知中的 "signature" 查询参数。</param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureForEcho(this DouyinMicroAppClient client, string webhookTimestamp, string webhookNonce, string webhookMsg, string webhookSignature)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                List<string> tmp = new List<string>(capacity: 4) { client.Credentials.PushToken!, webhookTimestamp, webhookNonce, webhookMsg };
                tmp.Sort(StringComparer.Ordinal);
                string sign = Utilities.SHA1Utility.Hash(string.Concat(tmp)).Value!;
                bool valid = string.Equals(sign, webhookSignature, StringComparison.OrdinalIgnoreCase);

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match. Maybe \"{webhookSignature}\" is an illegal signature."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromJson(this DouyinMicroAppClient client, string webhookJson)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                bool valid = Utilities.DyMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: encryptedEvent.TimestampString,
                    sNonce: encryptedEvent.Nonce,
                    sMsgEncrypt: encryptedEvent.EncryptedData,
                    sMsgSign: encryptedEvent.Signature
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromXml(this DouyinMicroAppClient client, string webhookXml)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            ErroredResult result;

            try
            {
                XDocument xdoc = XDocument.Parse(webhookXml);
                bool valid = Utilities.DyMsgCryptor.VerifySignature(
                    sToken: client.Credentials.PushToken!,
                    sTimestamp: xdoc.Root!.Element("TimeStamp")!.Value,
                    sNonce: xdoc.Root!.Element("Nonce")!.Value,
                    sMsgEncrypt: xdoc.Root!.Element("Encrypt")!.Value,
                    sMsgSign: xdoc.Root!.Element("MsgSignature")!.Value
                );

                if (valid)
                    result = ErroredResult.Ok();
                else
                    result = ErroredResult.Fail(new Exception($"Signature does not match."));
            }
            catch (Exception ex)
            {
                result = ErroredResult.Fail(ex);
            }

            return result;
        }
    }

    partial class DouyinMicroAppClientEventExtensions
    {
        private class InnerEncryptedEvent
        {
            [Newtonsoft.Json.JsonProperty("Encrypt")]
            [System.Text.Json.Serialization.JsonPropertyName("Encrypt")]
            [System.Xml.Serialization.XmlElement("Encrypt")]
            public string EncryptedData { get; set; } = default!;

            [Newtonsoft.Json.JsonProperty("TimeStamp")]
            [System.Text.Json.Serialization.JsonPropertyName("TimeStamp")]
            [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
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

        private static TEvent InnerDeserializeEventFromJson<TEvent>(DouyinMicroAppClient client, string webhookJson)
            where TEvent : DouyinMicroAppEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookJson is null) throw new ArgumentNullException(webhookJson);

            try
            {
                if (webhookJson.Contains("\"Encrypt\""))
                {
                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(webhookJson);
                    webhookJson = Utilities.DyMsgCryptor.AESDecrypt(cipherText: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return client.JsonSerializer.Deserialize<TEvent>(webhookJson);
            }
            catch (DouyinMicroAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new DouyinMicroAppException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }

        private static TEvent InnerDeserializeEventFromXml<TEvent>(DouyinMicroAppClient client, string webhookXml)
            where TEvent : DouyinMicroAppEvent
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (webhookXml is null) throw new ArgumentNullException(webhookXml);

            try
            {
                if (webhookXml.Contains("<Encrypt>") && webhookXml.Contains("</Encrypt>"))
                {
                    if (!Utilities.DyMsgCryptor.TryParseXml(webhookXml, out string encryptedXml))
                        throw new DouyinMicroAppException("Failed to decrypt event data, because the encrypted data is empty.");

                    webhookXml = Utilities.DyMsgCryptor.AESDecrypt(cipherText: encryptedXml, encodingAESKey: client.Credentials.PushEncodingAESKey!, out _);
                }

                return Utilities.XmlHelper.Deserialize<TEvent>(webhookXml);
            }
            catch (DouyinMicroAppException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new DouyinMicroAppException("Failed to deserialize event data. Please see the inner exception for more details.", ex);
            }
        }
    }
}
