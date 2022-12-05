using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/serviceDetail 接口的响应。</para>
    /// </summary>
    public class OrderServiceDetailResponse : DouyinShopResponse<OrderServiceDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Service : OrderGetServiceListResponse.Types.Data.Types.Service
                    {
                        /// <summary>
                        /// 获取或设置首次回复时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_reply_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("first_reply_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? FirstReplyTime { get; set; }

                        /// <summary>
                        /// 获取或设置操作状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_reject")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_reject")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsRejected { get; set; }

                        /// <summary>
                        /// 获取或设置驳回内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_detail")]
                        public string? RejectDetail { get; set; }

                        /// <summary>
                        /// 获取或设置驳回时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? RejectTime { get; set; }

                        /// <summary>
                        /// 获取或设置是否需要上传凭证。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("evidence_required")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("evidence_required")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool RequireEvidence { get; set; }

                        /// <summary>
                        /// 获取或设置凭证 DEMO URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("proof_demo")]
                        [System.Text.Json.Serialization.JsonPropertyName("proof_demo")]
                        public string? ProofDemoUrl { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_list")]
                        public string[]? ImageUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置驳回时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expiration_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("expiration_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset ExpireTime { get; set; }

                        /// <summary>
                        /// 获取或设置关闭原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("close_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("close_detail")]
                        public string? CloseDetail { get; set; }

                        /// <summary>
                        /// 获取或设置关闭时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("close_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("close_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? CloseTime { get; set; }
                    }

                    public class Log
                    {
                        /// <summary>
                        /// 获取或设置操作者名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_name")]
                        public string OperatorName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置处理时效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deal_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("deal_time")]
                        public string DealTime { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日志类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_log_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_log_type")]
                        public int ServiceLogType { get; set; }

                        /// <summary>
                        /// 获取或设置服务单详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_detail")]
                        public string ServiceDetail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_detail")]
                        public string? ReplyDetail { get; set; }

                        /// <summary>
                        /// 获取或设置驳回内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_detail")]
                        public string? RejectDetail { get; set; }

                        /// <summary>
                        /// 获取或设置关闭原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("close_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("close_detail")]
                        public string? CloseDetail { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_list")]
                        public string[]? ImageUrlList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置服务单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail")]
                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                public Types.Service Service { get; set; } = default!;

                /// <summary>
                /// 获取或设置日志记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logs")]
                [System.Text.Json.Serialization.JsonPropertyName("logs")]
                public Types.Log[] Logs { get; set; } = default!;
            }
        }
    }
}
