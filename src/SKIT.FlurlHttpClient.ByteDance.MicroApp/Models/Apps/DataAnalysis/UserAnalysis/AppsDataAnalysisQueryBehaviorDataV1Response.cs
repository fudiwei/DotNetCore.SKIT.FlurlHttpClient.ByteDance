namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_behavior_data 接口的响应。</para>
    /// </summary>
    public class AppsDataAnalysisQueryBehaviorDataV1Response : ByteDanceMicroAppResponse
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
                        /// 获取或设置时间格式类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_type")]
                        public int TimeType { get; set; }

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
                        /// 获取或设置新增用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("new_user_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("new_user_num")]
                        public int NewUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置累计用户数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_user_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_user_num")]
                        public int TotalUserCount { get; set; }

                        /// <summary>
                        /// 获取或设置分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_time")]
                        public int ShareTimes { get; set; }

                        /// <summary>
                        /// 获取或设置打开次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_time")]
                        public int OpenTimes { get; set; }

                        /// <summary>
                        /// 获取或设置人均打开次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("per_user_open_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("per_user_open_time")]
                        public double OpenTimesPerUser { get; set; }

                        /// <summary>
                        /// 获取或设置人均停留时长（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("per_user_stay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("per_user_stay_time")]
                        public double StayTimePerUser { get; set; }

                        /// <summary>
                        /// 获取或设置次均停留时长（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avg_stay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("avg_stay_time")]
                        public double AverageStayTime { get; set; }
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
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
