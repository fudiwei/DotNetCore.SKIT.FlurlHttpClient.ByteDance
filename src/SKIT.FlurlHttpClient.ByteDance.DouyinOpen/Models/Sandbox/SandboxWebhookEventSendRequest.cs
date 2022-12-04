namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /sandbox/webhook/event/send 接口的请求。</para>
    /// </summary>
    public class SandboxWebhookEventSendRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置需要模拟的事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = string.Empty;
    }
}
