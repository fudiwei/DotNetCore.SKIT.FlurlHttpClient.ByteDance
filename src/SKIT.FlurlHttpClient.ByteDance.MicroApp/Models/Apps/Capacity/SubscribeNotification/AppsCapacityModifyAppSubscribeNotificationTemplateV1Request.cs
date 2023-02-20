using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/modify_app_subscribe_notification_tpl 接口的请求。</para>
    /// </summary>
    public class AppsCapacityModifyAppSubscribeNotificationTemplateV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序消息模版 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        public string MessageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模版关键字列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
        public IList<string> KeywordList { get; set; } = new List<string>();
    }
}
