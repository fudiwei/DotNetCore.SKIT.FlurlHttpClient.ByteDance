using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi
{
    /// <summary>
    /// 为 <see cref="ByteDanceMicroAppOpenApiClient"/> 提供回调通知事件的扩展方法。
    /// </summary>
    public static class ByteDanceMicroAppOpenApiClientEventExtensions
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

        private static string InnerDecryptEventData(string sMsgEncrypt, string encodingAESKey)
        {
            if (string.IsNullOrWhiteSpace(sMsgEncrypt))
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Decrypt event failed, because of empty encrypted data.");

            if (string.IsNullOrWhiteSpace(encodingAESKey))
                throw new Exceptions.ByteDanceMicroAppEventSerializationException("Decrypt event failed, because there is no encoding AES key.");

            byte[] bCipher = Convert.FromBase64String(sMsgEncrypt);
            byte[] bKey = Convert.FromBase64String(encodingAESKey + "=");
            byte[] bIV = new byte[16];
            Array.Copy(bKey, bIV, 16);

            using Aes aes = Aes.Create();
            aes.KeySize = 256;
            aes.BlockSize = 128;
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.None;
            aes.Key = bKey;
            aes.IV = bIV;

            using ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] decryptedBytes = decryptor.TransformFinalBlock(bCipher, 0, bCipher.Length);

            byte[] bytes = Decode(decryptedBytes);
            const int RANDOM_BYTES_POS = 32;
            // byte数组的第32、33、34、35个元素代表了消息体的真实字符个数，也就是长度
            // 取32至35转大端序
            var lengthArray = bytes.AsSpan().Slice(RANDOM_BYTES_POS, 4).ToArray().Reverse().ToArray();
            // 将四个byte解析为一个32位的数字，数字的值也就是消息体的String格式下的长度
            int msgLength = BitConverter.ToInt32(lengthArray, 0);

            // 根据解析出来的消息体长度值，截取真实的消息体
            byte[] contentBytes = new byte[msgLength];
            int msgStartIndex = RANDOM_BYTES_POS + 4;
            Array.Copy(bytes, msgStartIndex, contentBytes, 0, msgLength);
            string content = Encoding.UTF8.GetString(contentBytes);
            return content;
        }

        private static byte[] Decode(byte[] decrypted)
        {
            int pad = decrypted[decrypted.Length - 1];
            if (pad < 1 || pad > 32)
            {
                pad = 0;
            }
            int length = decrypted.Length - pad;
            var destinationArray = new byte[length];
            Array.Copy(decrypted, destinationArray, length);

            return destinationArray;
        }

        private static bool InnerVerifyEventSignature(string sToken, string sTimestamp, string sNonce, string sMsgEncrypt, string sMsgSign)
        {
            ISet<string> set = new SortedSet<string>(StringComparer.Ordinal)
            {
                sToken,
                sTimestamp,
                sNonce,
                sMsgEncrypt
            };

            string raw = string.Join(string.Empty, set.ToArray());
            string sign = Utilities.SHA1Utility.Hash(raw);
            return string.Equals(sign, sMsgSign, StringComparison.OrdinalIgnoreCase);
        }

        private static TEvent InnerDeserializeEventFromJson<TEvent>(ByteDanceMicroAppOpenApiClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppOpenApiEvent
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (string.IsNullOrEmpty(callbackJson)) throw new ArgumentNullException(callbackJson);

            try
            {
                if (callbackJson.Contains("\"Encrypt\""))
                {
                    InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                    callbackJson = InnerDecryptEventData(sMsgEncrypt: encryptedEvent.EncryptedData, encodingAESKey: client.Credentials.PushEncodingAESKey!);
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

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static TEvent DeserializeEventFromJson<TEvent>(this ByteDanceMicroAppOpenApiClient client, string callbackJson)
            where TEvent : ByteDanceMicroAppOpenApiEvent, ByteDanceMicroAppOpenApiEvent.Serialization.IJsonSerializable, new()
        {
            return InnerDeserializeEventFromJson<TEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>从 JSON 反序列化得到 <see cref="ByteDanceMicroAppOpenApiEvent"/> 对象。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static ByteDanceMicroAppOpenApiEvent DeserializeEventFromJson(this ByteDanceMicroAppOpenApiClient client, string callbackJson)
        {
            return InnerDeserializeEventFromJson<ByteDanceMicroAppOpenApiEvent>(client, callbackJson);
        }

        /// <summary>
        /// <para>验证回调通知事件签名。</para>
        /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption </para>
        /// <para>REF: https://partner.open-douyin.com/docs/resource/zh-CN/thirdparty/overview-guide/smallprogram/encryption </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="callbackJson"></param>
        /// <returns></returns>
        public static bool VerifyEventSignatureFromJson(this ByteDanceMicroAppOpenApiClient client, string callbackJson)
        {
            if (client == null) throw new ArgumentNullException(nameof(client));
            if (callbackJson == null) throw new ArgumentNullException(nameof(callbackJson));

            try
            {
                InnerEncryptedEvent encryptedEvent = client.JsonSerializer.Deserialize<InnerEncryptedEvent>(callbackJson);
                return InnerVerifyEventSignature(
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
    }
}
