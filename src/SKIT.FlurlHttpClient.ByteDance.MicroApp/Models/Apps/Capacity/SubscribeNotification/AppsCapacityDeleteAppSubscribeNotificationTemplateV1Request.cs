namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/delete_app_subscribe_notification_tpl 接口的请求。</para>
    /// </summary>
    public class AppsCapacityDeleteAppSubscribeNotificationTemplateV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序消息模版 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = string.Empty;
    }
}
