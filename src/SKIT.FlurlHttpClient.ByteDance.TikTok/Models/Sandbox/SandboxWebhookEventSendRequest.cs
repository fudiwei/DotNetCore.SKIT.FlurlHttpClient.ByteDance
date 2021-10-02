namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /sandbox/webhook/event/send 接口的请求。</para>
    /// </summary>
    public class SandboxWebhookEventSendRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置需要模拟的事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string EventType { get; set; } = string.Empty;
    }
}
