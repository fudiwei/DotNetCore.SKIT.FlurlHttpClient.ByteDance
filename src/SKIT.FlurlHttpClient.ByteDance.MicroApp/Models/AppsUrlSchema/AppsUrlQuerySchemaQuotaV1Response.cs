namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/url/query_schema_quota/ 接口的响应。</para>
    /// </summary>
    public class AppsUrlQuerySchemaQuotaV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Quota
                    {
                        /// <summary>
                        /// 获取或设置已生成次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schema_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("schema_used")]
                        public int UsedCount { get; set; }

                        /// <summary>
                        /// 获取或设置次数上限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("schema_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("schema_limit")]
                        public int LimitCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置长期有效的配额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("long_term_schema_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("long_term_schema_quota")]
                public Types.Quota LongTermQuota { get; set; } = default!;

                /// <summary>
                /// 获取或设置短期有效的配额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("short_term_schema_quota")]
                [System.Text.Json.Serialization.JsonPropertyName("short_term_schema_quota")]
                public Types.Quota ShortTermQuota { get; set; } = default!;
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
