namespace SKIT.FlurlHttpClient.ByteDance.TikTok
{
    /// <summary>
    /// 表示抖音开放平台 API Webhook 事件的基类。
    /// </summary>
    public class TikTokEvent
    {
        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public string Event { get; set; } = default!;

        /// <summary>
        /// 获取或设置应用的 ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string ClientKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件发起者用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("from_user_id")]
        public string FromUserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件接收者用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("to_user_id")]
        public string? ToUserId { get; set; }
    }

    /// <summary>
    /// 表示抖音开放平台 API Webhook 事件的泛型基类。
    /// </summary>
    public abstract class TikTokEvent<TContent> : TikTokEvent
    {
        /// <summary>
        /// 获取或设置事件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public TContent Content { get; set; } = default!;
    }
}
