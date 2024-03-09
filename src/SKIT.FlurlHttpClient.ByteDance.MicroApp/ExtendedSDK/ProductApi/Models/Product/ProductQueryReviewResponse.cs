using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_review 接口的响应。</para>
    /// </summary>
    public class ProductQueryReviewResponse : DouyinMicroAppProductApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductReview
                    {
                        public static class Types
                        {
                            public class CourseReview
                            {
                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置下架或审核不通过原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string? RejectReason { get; set; }

                                /// <summary>
                                /// 获取或设置最近一次审核 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("latest_audit_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("latest_audit_id")]
                                public string? LatestAuditId { get; set; }
                            }

                            public class FulfillmentReview
                            {
                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置下架或审核不通过原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string? RejectReason { get; set; }

                                /// <summary>
                                /// 获取或设置最近一次审核 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("latest_audit_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("latest_audit_id")]
                                public string? LatestAuditId { get; set; }

                                /// <summary>
                                /// 获取或设置履约文件资源路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fulfillment_uri")]
                                [System.Text.Json.Serialization.JsonPropertyName("fulfillment_uri")]
                                public string? FulfillmentPath { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置课程审核信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("course")]
                        [System.Text.Json.Serialization.JsonPropertyName("course")]
                        public Types.CourseReview? CourseReview { get; set; }

                        /// <summary>
                        /// 获取或设置履约审核信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fulfillment")]
                        [System.Text.Json.Serialization.JsonPropertyName("fulfillment")]
                        public Types.FulfillmentReview[]? FulfillmentReviewList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品审核信息字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products_review")]
                [System.Text.Json.Serialization.JsonPropertyName("products_review")]
                public IDictionary<long, Types.ProductReview>? ProductReviewMap { get; set; }
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
