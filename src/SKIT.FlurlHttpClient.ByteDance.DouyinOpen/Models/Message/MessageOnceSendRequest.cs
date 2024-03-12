using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /message/once/send/ 接口的请求。</para>
    /// </summary>
    public class MessageOnceSendRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置客户端消息标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("client_msg_id")]
        public string? ClientMessageId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("template_arg_map")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IDictionary<string, string>? TemplateArgumentMap { get; set; }

        /// <summary>
        /// 获取或设置消息跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("schema_url")]
        [System.Text.Json.Serialization.JsonPropertyName("schema_url")]
        public string? SchemaUrl { get; set; }
    }
}
