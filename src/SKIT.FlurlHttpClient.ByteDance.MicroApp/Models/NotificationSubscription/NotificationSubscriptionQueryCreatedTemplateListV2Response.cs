namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/notification/v2/subscription/query_created_tpl_list/ 接口的响应。</para>
    /// </summary>
    public class NotificationSubscriptionQueryCreatedTemplateListV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Template
                    {
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
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置宿主 App 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("host_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("host_list")]
                        public string[] HostNameList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置关键词列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyword_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
                        public string[] KeywordList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置操作时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operating_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("operating_time")]
                        public long OperatingTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_list")]
                [System.Text.Json.Serialization.JsonPropertyName("template_list")]
                public Types.Template[] TemplateList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
