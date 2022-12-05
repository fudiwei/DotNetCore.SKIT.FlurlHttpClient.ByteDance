namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/poi/task/query 接口的响应。</para>
    /// </summary>
    public class GoodLifePOITaskQueryV1Response : DouyinOpenResponse<GoodLifePOITaskQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class TaskResult
                    {
                        public static class Types
                        {
                            public class BusinessPartnershipResult
                            {
                                /// <summary>
                                /// 获取或设置合作关系 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("partnership_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("partnership_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long PartnershipId { get; set; }

                                /// <summary>
                                /// 获取或设置任务状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置拒绝原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string? RejectReason { get; set; }
                            }

                            public class TrademarkResult
                            {
                                /// <summary>
                                /// 获取或设置商家 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                public string AccountId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置任务状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置拒绝原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string? RejectReason { get; set; }
                            }

                            public class POIResult
                            {
                                public static class Types
                                {
                                    public class AuditResult
                                    {
                                        /// <summary>
                                        /// 获取或设置审核项标识
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("key")]
                                        [System.Text.Json.Serialization.JsonPropertyName("key")]
                                        public string AuditKey { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置审核状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                                        public int Status { get; set; }

                                        /// <summary>
                                        /// 获取或设置拒绝原因。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                        public string? RejectReason { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置拒绝原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string? RejectReason { get; set; }

                                /// <summary>
                                /// 获取或设置审核结果列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("key_audit_result_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("key_audit_result_list")]
                                public Types.AuditResult[]? AuditResultList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long TaskId { get; set; }

                        /// <summary>
                        /// 获取或设置三方 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                        public string ThirdId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 POI ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("match_poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("match_poi_id")]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商服绑定关系结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_partnership_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_partnership_result")]
                        public Types.BusinessPartnershipResult? BusinessPartnershipResult { get; set; }

                        /// <summary>
                        /// 获取或设置品牌审核结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_result")]
                        public Types.TrademarkResult? TrademarkResult { get; set; }

                        /// <summary>
                        /// 获取或设置门店修改结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_result")]
                        public Types.POIResult? POIUpdateResult { get; set; }

                        /// <summary>
                        /// 获取或设置门店装修结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_decoration_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_decoration_result")]
                        public Types.POIResult? POIDecorationResult { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置任务结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_results")]
                [System.Text.Json.Serialization.JsonPropertyName("task_results")]
                public Types.TaskResult[] TaskResultList { get; set; } = default!;
            }
        }
    }
}
