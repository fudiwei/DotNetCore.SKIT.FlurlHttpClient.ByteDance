namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /customer_service/{version}/performance 接口的响应。</para>
    /// </summary>
    public class CustomerServiceGetPerformanceResponse : TikTokShopResponse<CustomerServiceGetPerformanceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Performance
                    {
                        /// <summary>
                        /// 获取或设置会话数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("support_session_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("support_session_count")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public int SupportSessionCount { get; set; }

                        /// <summary>
                        /// 获取或设置回复率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("response_percentage")]
                        [System.Text.Json.Serialization.JsonPropertyName("response_percentage")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ResponsePercentage { get; set; }

                        /// <summary>
                        /// 获取或设置客户满意率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("satisfaction_percentage")]
                        [System.Text.Json.Serialization.JsonPropertyName("satisfaction_percentage")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SatisfactionPercentage { get; set; }

                        /// <summary>
                        /// 获取或设置平均首次响应时间（单位：分钟）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("response_time_mins")]
                        [System.Text.Json.Serialization.JsonPropertyName("response_time_mins")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AverageResponseTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("performance")]
                [System.Text.Json.Serialization.JsonPropertyName("performance")]
                public Types.Performance Performance { get; set; } = default!;
            }
        }
    }
}
