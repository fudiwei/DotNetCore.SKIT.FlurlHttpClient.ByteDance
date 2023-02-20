using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/add_app_subscribe_notification_tpl 接口的请求。</para>
    /// </summary>
    public class AppsCapacityAddAppSubscribeNotificationTemplateV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 获取或设置模版关键字列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
        public IList<string> KeywordList { get; set; } = new List<string>();
    }
}
