namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/recall/msg/ 接口的请求。</para>
    /// </summary>
    public class IMRecallMessageRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置消息 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string? ServerMessageId { get; set; }

        /// <summary>
        /// 获取或设置会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conversation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationShortId { get; set; }

        /// <summary>
        /// 获取或设置会话类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conversation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("conversation_type")]
        public int? ConversationType { get; set; }
    }
}
