namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_aweme_relation_list/ 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQueryAwemeRelationListV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class AwemeRelation
                    {
                        public static class Types
                        {
                            public class Capacity
                            {
                                /// <summary>
                                /// 获取或设置能力标识。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("capacity_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("capacity_key")]
                                public string CapacityKey { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置绑定状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置绑定失败原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fail_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                                public string? FailReason { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aweme_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AwemeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置账号类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                        public int AccountType { get; set; }

                        /// <summary>
                        /// 获取或设置绑定能力列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("capacity_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("capacity_list")]
                        public Types.Capacity[] CapacityList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置绑定状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bind_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
                        public int BindStatus { get; set; }

                        /// <summary>
                        /// 获取或设置绑定失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置绑定抖音号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.AwemeRelation[] AwemeRelationList { get; set; } = default!;

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
