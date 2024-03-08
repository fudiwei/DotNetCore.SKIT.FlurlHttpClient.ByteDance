namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /notification/v2/subscription/query_app_tpl/ 接口的响应。</para>
    /// </summary>
    public class NotificationSubscriptionQueryAppTemplateV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Template : NotificationSubscriptionQueryTemplateListV2Response.Types.Data.Types.Template
                    {
                        /// <summary>
                        /// 获取或设置消息模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_id")]
                        public string MessageId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置消息模板列表。
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
