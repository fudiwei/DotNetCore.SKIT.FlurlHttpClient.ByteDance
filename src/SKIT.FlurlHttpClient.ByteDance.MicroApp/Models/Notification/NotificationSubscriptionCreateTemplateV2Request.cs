using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /notification/v2/subscription/create_tpl/ 接口的请求。</para>
    /// </summary>
    public class NotificationSubscriptionCreateTemplateV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置服务类目 ID 字符串（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("category_ids")]
        public string CategoryIdString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订阅消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("classification")]
        [System.Text.Json.Serialization.JsonPropertyName("classification")]
        public int Classification { get; set; }

        /// <summary>
        /// 获取或设置模板标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置宿主 App 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host_list")]
        [System.Text.Json.Serialization.JsonPropertyName("host_list")]
        public IList<string> HostNameList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置关键词列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
        public IList<string> KeywordList { get; set; } = new List<string>();
    }
}
