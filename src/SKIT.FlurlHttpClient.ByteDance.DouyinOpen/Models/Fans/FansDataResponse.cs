namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/douyin/v1/user/fans_data/ 接口的响应。</para>
    /// </summary>
    public class FansDataResponse : DouyinOpenResponse<FansDataResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Result
                    {
                        public static class Types
                        {
                            public class ItemValue
                            {
                                /// <summary>
                                /// 获取或设置分布的种类。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item")]
                                [System.Text.Json.Serialization.JsonPropertyName("item")]
                                public string Item { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分布的数值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public int Value { get; set; }
                            }

                            public class FlowDistribution
                            {
                                /// <summary>
                                /// 获取或设置流量来源。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flow")]
                                [System.Text.Json.Serialization.JsonPropertyName("flow")]
                                public string Flow { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置流量总值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("all_sum")]
                                [System.Text.Json.Serialization.JsonPropertyName("all_sum")]
                                public int AllSum { get; set; }

                                /// <summary>
                                /// 获取或设置粉丝贡献流量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fans_sum")]
                                [System.Text.Json.Serialization.JsonPropertyName("fans_sum")]
                                public int FansSum { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置粉丝活跃天数分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("active_days_distributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("active_days_distributions")]
                        public Types.ItemValue[] ActiveDaysDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝年龄分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("age_distributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("age_distributions")]
                        public Types.ItemValue[] AgeDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝性别分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gender_distributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("gender_distributions")]
                        public Types.ItemValue[] GenderDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝设备分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("device_distributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("device_distributions")]
                        public Types.ItemValue[] DeviceDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝地域分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("geographical_distributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("geographical_distributions")]
                        public Types.ItemValue[] GeographicalDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝兴趣分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("interest_distributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("interest_distributions")]
                        public Types.ItemValue[] InterestDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝流量贡献分布。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flow_contributions")]
                        [System.Text.Json.Serialization.JsonPropertyName("flow_contributions")]
                        public Types.FlowDistribution[] FlowDistributions { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置粉丝总数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("all_fans_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("all_fans_num")]
                        public int TotalFansCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fans_data")]
                [System.Text.Json.Serialization.JsonPropertyName("fans_data")]
                public Types.Result Result { get; set; } = default!;
            }
        }
    }
}
