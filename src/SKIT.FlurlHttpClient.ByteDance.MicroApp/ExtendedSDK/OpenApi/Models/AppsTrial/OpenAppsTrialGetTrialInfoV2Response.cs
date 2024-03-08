namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v2/trial/get_trial_info 接口的响应。</para>
    /// </summary>
    public class OpenAppsTrialGetTrialInfoV2Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class TrialLimitInfo
                    {
                        /// <summary>
                        /// 获取或设置是否被限制进阶能力。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_capability_limited")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_capability_limited")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsCapabilityLimited { get; set; }

                        /// <summary>
                        /// 获取或设置是否被限制支付额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_payment_restricted")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_payment_restricted")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsPaymentRestricted { get; set; }

                        /// <summary>
                        /// 获取或设置是否被限制流量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_traffic_limited")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_traffic_limited")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsTrafficLimited { get; set; }
                    }

                    public class TrialTaskInfo
                    {
                        /// <summary>
                        /// 获取或设置任务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置任务目标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("target")]
                        [System.Text.Json.Serialization.JsonPropertyName("target")]
                        public int Target { get; set; }

                        /// <summary>
                        /// 获取或设置任务进度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("progress")]
                        [System.Text.Json.Serialization.JsonPropertyName("progress")]
                        public int Progress { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置信用分分值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_credit_score")]
                [System.Text.Json.Serialization.JsonPropertyName("app_credit_score")]
                public int CreditScore { get; set; }

                /// <summary>
                /// 获取或设置是否处于试运营期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_trial")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_trial")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool IsTrial { get; set; }

                /// <summary>
                /// 获取或设置试运营期限制信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trial_limit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("trial_limit_info")]
                public Types.TrialLimitInfo? TrialLimitInfo { get; set; }

                /// <summary>
                /// 获取或设置试运营期通过分数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trial_pass_score")]
                [System.Text.Json.Serialization.JsonPropertyName("trial_pass_score")]
                public int? TrialPassScore { get; set; }

                /// <summary>
                /// 获取或设置试运营期任务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trial_task_info")]
                [System.Text.Json.Serialization.JsonPropertyName("trial_task_info")]
                public Types.TrialTaskInfo[]? TrialTaskList { get; set; }
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
