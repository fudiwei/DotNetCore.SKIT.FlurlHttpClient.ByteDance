namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /enterprise/im/message/send 接口的请求。</para>
    /// </summary>
    public class EnterpriseIMMessageSendRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置文字内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// 获取或设置素材 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string? ItemId { get; set; }

                /// <summary>
                /// 获取或设置卡片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string? CardId { get; set; }
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyContentNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Content?>
            {
            }

            internal class RequestPropertyContentSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Content?>
            {
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
        [Newtonsoft.Json.JsonProperty("to_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("to_user_id")]
        public string ToUserOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message_type")]
        [System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string MessageType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息体。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyContentNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyContentSystemTextJsonConverter))]
        public Types.Content Content { get; set; } = new Types.Content();

        /// <summary>
        /// 获取或设置客服 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("persona_id")]
        [System.Text.Json.Serialization.JsonPropertyName("persona_id")]
        public string? PersonaId { get; set; }
    }
}
