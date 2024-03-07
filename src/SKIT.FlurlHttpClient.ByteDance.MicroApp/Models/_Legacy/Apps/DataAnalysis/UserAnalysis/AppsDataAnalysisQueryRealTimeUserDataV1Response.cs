using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_real_time_user_data 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-02 下线。")]
    public class AppsDataAnalysisQueryRealTimeUserDataV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class BehaviorData
                    {
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
                        /// 获取或设置打开次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                        public int OpenTimes { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置行为分析数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("behaviors")]
                [System.Text.Json.Serialization.JsonPropertyName("behaviors")]
                public Types.BehaviorData[] BehaviorDataList { get; set; } = default!;
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
