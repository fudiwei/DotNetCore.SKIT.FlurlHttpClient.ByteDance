namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal
{
    /// <summary>
    /// 表示 TikTok Developer APIv2 Webhook 事件的基类。
    /// </summary>
    public class TikTokV2Event : ICommonWebhookEvent
    {
        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event")]
        [System.Text.Json.Serialization.JsonPropertyName("event")]
        public virtual string? Event { get; set; }

        /// <summary>
        /// 获取或设置 TikTok Developer ClientKey。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public virtual string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_openid")]
        public virtual string? UserOpenId { get; set; }

        /// <summary>
        /// 获取或设置事件创建时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public virtual long? CreateTimestamp { get; set; }
    }

    /// <summary>
    /// 表示 TikTok Developer APIv2 Webhook 事件的泛型基类。
    /// </summary>
    public abstract class TikTokV2Event<TContent> : TikTokV2Event
    {
        /// <summary>
        /// 获取或设置事件内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
        public virtual TContent? EventContent { get; set; }
    }
}
