using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /message/once/send 接口的请求。</para>
    /// </summary>
    public class MessageOnceSendRequest : TikTokRequest
    {
        internal static class Converters
        {
            internal class NewtonsoftJsonTemplateArgumentMap : Newtonsoft.Json.JsonConverter<IDictionary<string, string>?>
            {
                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override IDictionary<string, string>? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, IDictionary<string, string>? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
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

                        return Newtonsoft.Json.JsonConvert.DeserializeObject<IDictionary<string, string>>(value);
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, IDictionary<string, string>? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(Newtonsoft.Json.JsonConvert.SerializeObject(value, Newtonsoft.Json.Formatting.None));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonTemplateArgumentMap : System.Text.Json.Serialization.JsonConverter<IDictionary<string, string>?>
            {
                public override IDictionary<string, string>? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
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

                        return System.Text.Json.JsonSerializer.Deserialize<IDictionary<string, string>>(value, options);
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, IDictionary<string, string>? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(System.Text.Json.JsonSerializer.Serialize(value, options));
                    else
                        writer.WriteNullValue();
                }
            }
        }

        /// <summary>
        /// 获取或设置客户端消息标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("client_msg_id")]
        public string? ClientMessageId { get; set; }

        /// <summary>
        /// 获取或设置消息的接收方 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("to_open_id")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息内容自定义字段字典。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_arg_map")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonTemplateArgumentMap))]
        [System.Text.Json.Serialization.JsonPropertyName("template_arg_map")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonTemplateArgumentMap))]
        public IDictionary<string, string>? TemplateArgumentMap { get; set; }

        /// <summary>
        /// 获取或设置消息跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schema_url")]
        [System.Text.Json.Serialization.JsonPropertyName("schema_url")]
        public string? SchemaUrl { get; set; }
    }
}
