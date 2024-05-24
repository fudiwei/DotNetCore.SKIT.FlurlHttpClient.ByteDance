using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/notification/v2/subscription/notify_user/ 接口的请求。</para>
    /// </summary>
    public class NotificationSubscriptionNotifyUserV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置消息模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板内容信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public IDictionary<string, string> Data { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// 获取或设置跳转的页面。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public string? PagePath { get; set; }
    }
}
