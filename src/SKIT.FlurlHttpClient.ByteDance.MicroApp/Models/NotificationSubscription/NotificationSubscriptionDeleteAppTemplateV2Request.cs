namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/notification/v2/subscription/delete_app_tpl/ 接口的请求。</para>
    /// </summary>
    public class NotificationSubscriptionDeleteAppTemplateV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置消息模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = string.Empty;
    }
}
