using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/capacity/create_subscribe_notification_tpl 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-30 下线。")]
    public class AppsCapacityCreateAppSubscribeNotificationTemplateV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置订阅消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("classification")]
        [System.Text.Json.Serialization.JsonPropertyName("classification")]
        public int Classification { get; set; }

        /// <summary>
        /// 获取或设置模版标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模版关键字列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword_list")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
        public IList<string> KeywordList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置类目 ID 字符串（以逗号分隔）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("category_ids")]
        public string CategoryIdString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置宿主名称列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host_list")]
        [System.Text.Json.Serialization.JsonPropertyName("host_list")]
        public IList<string> HostNameList { get; set; } = new List<string>();
    }
}
