using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/replyService 接口的请求。</para>
    /// </summary>
    public class OrderReplyServiceRequest : TikTokShopRequest
    {
        internal static class Converters
        {
            internal class NewtonsoftJsonStringListWithVBarConverter : Newtonsoft.Json.JsonConverter<IList<string>?>
            {
                private const char SEPARATOR = '|';

                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override IList<string>? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, IList<string>? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value == null)
                            return existingValue;

                        return value.Split(SEPARATOR);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, IList<string>? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(string.Join(SEPARATOR.ToString(), value));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonStringListWithVBarConverter : System.Text.Json.Serialization.JsonConverter<IList<string>?>
            {
                private const char SEPARATOR = '|';

                public override IList<string>? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value == null)
                            return null;

                        return value.Split(SEPARATOR);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, IList<string>? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(string.Join(SEPARATOR.ToString(), value));
                    else
                        writer.WriteNullValue();
                }
            }
        }

        /// <summary>
        /// 获取或设置服务请求 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 获取或设置商家答复内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reply")]
        [System.Text.Json.Serialization.JsonPropertyName("reply")]
        public string ReplyDetail { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回复凭证 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evidence")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonStringListWithVBarConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("evidence")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonStringListWithVBarConverter))]
        public IList<string>? ProofUrlList { get; set; }

        protected internal override string GetApiMethod()
        {
            return string.Intern("order.replyService");
        }
    }
}
