using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_retention_data 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryRetentionDataV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class RetentionData
                    {
                        public static class Types
                        {
                            public class RetentionRate
                            {
                                /// <summary>
                                /// 获取或设置几天后。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("day")]
                                [System.Text.Json.Serialization.JsonPropertyName("day")]
                                public int Days { get; set; }

                                /// <summary>
                                /// 获取或设置留存率（范围：0～1）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("rate")]
                                public decimal Rate { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置时间字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time")]
                        [System.Text.Json.Serialization.JsonPropertyName("time")]
                        public string TimeString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活跃用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("active_user_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("active_user_num")]
                        public int ActiveUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置留存率列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retention_rate_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("retention_rate_list")]
                        public Types.RetentionRate[] RetentionRateList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置留存数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retention_data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("retention_data_list")]
                public Types.RetentionData[] RetentionDataList { get; set; } = default!;
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
