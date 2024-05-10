namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /event/{version}/webhooks 接口的请求。</para>
    /// </summary>
    public class EventUpdateWebhookRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type", Order = 1)]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [System.Text.Json.Serialization.JsonPropertyOrder(1)]
        public string EventType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address", Order = 2)]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        [System.Text.Json.Serialization.JsonPropertyOrder(2)]
        public string WebhookUrl { get; set; } = string.Empty;
    }
}
