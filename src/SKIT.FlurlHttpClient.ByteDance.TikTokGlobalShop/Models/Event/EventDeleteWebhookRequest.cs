namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /event/{version}/webhooks 接口的请求。</para>
    /// </summary>
    public class EventDeleteWebhookRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = string.Empty;
    }
}
