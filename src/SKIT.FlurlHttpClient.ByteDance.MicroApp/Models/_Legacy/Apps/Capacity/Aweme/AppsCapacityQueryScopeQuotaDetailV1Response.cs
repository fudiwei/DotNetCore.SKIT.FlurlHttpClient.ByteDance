using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_scope_quota_detail 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-01 下线。")]
    public class AppsCapacityQueryScopeQuotaDetailV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Scope
                    {
                        /// <summary>
                        /// 获取或设置作用域 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scope")]
                        [System.Text.Json.Serialization.JsonPropertyName("scope")]
                        public string ScopeKey { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置免费总额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("free_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("free_total")]
                        public int FreeTotalQuota { get; set; }

                        /// <summary>
                        /// 获取或设置已用免费额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("free_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("free_used")]
                        public int FreeUsedQuota { get; set; }

                        /// <summary>
                        /// 获取或设置付费总额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("charge_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("charge_total")]
                        public int ChargeTotalQuota { get; set; }

                        /// <summary>
                        /// 获取或设置已用付费额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("charge_used")]
                        [System.Text.Json.Serialization.JsonPropertyName("charge_used")]
                        public int ChargeUsedQuota { get; set; }

                        /// <summary>
                        /// 获取或设置剩余付费额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("charge_remain")]
                        [System.Text.Json.Serialization.JsonPropertyName("charge_remain")]
                        public int ChargeRemainingQuota { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以申请提升额度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_apply_quota")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("can_apply_quota")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool CanApplyQuota { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置作用域列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope_list")]
                [System.Text.Json.Serialization.JsonPropertyName("scope_list")]
                public Types.Scope[] ScopeList { get; set; } = default!;
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
