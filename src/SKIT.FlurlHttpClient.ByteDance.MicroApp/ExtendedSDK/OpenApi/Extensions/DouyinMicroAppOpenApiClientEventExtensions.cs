using System;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// 为 <see cref="DouyinMicroAppOpenApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static partial class DouyinMicroAppOpenApiClientEventExtensions
    {
        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinMicroAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this DouyinMicroAppOpenApiClient client, string webhookJson)
            where TEvent : DouyinMicroAppOpenApiEvent, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="DouyinMicroAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static DouyinMicroAppOpenApiEvent DeserializeEventFromJson(this DouyinMicroAppOpenApiClient client, string webhookJson)
        {
            return InnerDeserializeEventFromJson<DouyinMicroAppOpenApiEvent>(client, webhookJson);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="DouyinMicroAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromXml<TEvent>(this DouyinMicroAppOpenApiClient client, string webhookXml)
            where TEvent : DouyinMicroAppOpenApiEvent, new()
        {
            return InnerDeserializeEventFromXml<TEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>从 XML 反序列化得到 <see cref="DouyinMicroAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static DouyinMicroAppOpenApiEvent DeserializeEventFromXml(this DouyinMicroAppOpenApiClient client, string webhookXml)
        {
            return InnerDeserializeEventFromXml<DouyinMicroAppOpenApiEvent>(client, webhookXml);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookJson"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromJson(this DouyinMicroAppOpenApiClient client, string webhookJson)
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
        /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="webhookXml"></param>
        /// <returns></returns>
        public static ErroredResult VerifyEventSignatureFromXml(this DouyinMicroAppOpenApiClient client, string webhookXml)
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

    partial class DouyinMicroAppOpenApiClientEventExtensions
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

        private static TEvent InnerDeserializeEventFromJson<TEvent>(DouyinMicroAppOpenApiClient client, string webhookJson)
            where TEvent : DouyinMicroAppOpenApiEvent
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

        private static TEvent InnerDeserializeEventFromXml<TEvent>(DouyinMicroAppOpenApiClient client, string webhookXml)
            where TEvent : DouyinMicroAppOpenApiEvent
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
