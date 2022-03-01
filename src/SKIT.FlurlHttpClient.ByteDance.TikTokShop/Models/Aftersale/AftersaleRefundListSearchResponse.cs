using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/refundListSearch 接口的响应。</para>
    /// </summary>
    public class AftersaleRefundListSearchResponse : TikTokShopResponse<AftersaleRefundListSearchResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Aftersale
                    {
                        public static class Types
                        {
                            public class AftersaleItem
                            {
                                public static class Types
                                {
                                    public class SKUSpecification
                                    {
                                        /// <summary>
                                        /// 获取或设置规格名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置规格值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                                        public string Value { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string OrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品头图。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_img")]
                                public string ProductImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("num")]
                                [System.Text.Json.Serialization.JsonPropertyName("num")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置支付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("post_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("post_amount")]
                                public int PostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                                public int Refundmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款运费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_post_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_post_amount")]
                                public int RefundPostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置部分退款类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("part_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("part_type")]
                                public int RefundPartType { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 规格列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_spec")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_spec")]
                                public Types.SKUSpecification[] SKUSpecificationList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后标签列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_service")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_service")]
                                public string[] AftersaleServiceList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置创建时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset CreateTime { get; set; }
                            }

                            public class AftersaleRecord
                            {
                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string OrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string AftersaleId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置订单类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_order_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_order_type")]
                                public int OrderType { get; set; }

                                /// <summary>
                                /// 获取或设置操作类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("op_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("op_type")]
                                public string OperateType { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作人角色。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("role")]
                                [System.Text.Json.Serialization.JsonPropertyName("role")]
                                public string OperateRole { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作人名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("op_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("op_name")]
                                public string OperatorName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("op_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("op_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset OperateTime { get; set; }

                                /// <summary>
                                /// 获取或设置操作结果编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("conclusion")]
                                [System.Text.Json.Serialization.JsonPropertyName("conclusion")]
                                public int ConclusionCode { get; set; }

                                /// <summary>
                                /// 获取或设置操作意见。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("comment")]
                                [System.Text.Json.Serialization.JsonPropertyName("comment")]
                                public string? Comment { get; set; }

                                /// <summary>
                                /// 获取或设置凭证 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("evidence")]
                                [System.Text.Json.Serialization.JsonPropertyName("evidence")]
                                public string[]? EvidenceUrlList { get; set; }

                                /// <summary>
                                /// 获取或设置备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("remark")]
                                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                                public string? Remark { get; set; }

                                /// <summary>
                                /// 获取或设置收到货物说状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("got_pkg")]
                                [System.Text.Json.Serialization.JsonPropertyName("got_pkg")]
                                public int? GotPackageStatus { get; set; }

                                /// <summary>
                                /// 获取或设置退款类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
                                public int? RefundType { get; set; }

                                /// <summary>
                                /// 获取或设置物流单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("logistics_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                                public string? LogisticsNumber { get; set; }

                                /// <summary>
                                /// 获取或设置物流公司编号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("company_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                                public string? LogisticsCompanyCode { get; set; }

                                /// <summary>
                                /// 获取或设置物流公司名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("company_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                                public string? LogisticsCompanyName { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pid")]
                        [System.Text.Json.Serialization.JsonPropertyName("pid")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string ShopOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售后单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string AftersaleId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置申请时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset ApplyTime { get; set; }

                        /// <summary>
                        /// 获取或设置售后类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_type")]
                        public int? AftersaleType { get; set; }

                        /// <summary>
                        /// 获取或设置自动流转类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("deadline_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("deadline_type")]
                        public int DeadlineType { get; set; }

                        /// <summary>
                        /// 获取或设置超时自动流转截止时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status_deadline")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("status_deadline")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? StatusDeadlineTime { get; set; }

                        /// <summary>
                        /// 获取或设置售后原因描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason_desc")]
                        public string ReasonDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售后状态类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_status")]
                        public int AftersaleStatus { get; set; }

                        /// <summary>
                        /// 获取或设置售后状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_status_desc")]
                        public string AftersaleStatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售后流程描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_process_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_process_desc")]
                        public string AftersaleProcessDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货物流状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_status_desc")]
                        public string ReturnStatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
                        public int RefundType { get; set; }

                        /// <summary>
                        /// 获取或设置退款类型描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_refund_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_refund_type_desc")]
                        public string RefundTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                        public int RefundStatus { get; set; }

                        /// <summary>
                        /// 获取或设置部分退款类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("part_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("part_type")]
                        public int RefundPartType { get; set; }

                        /// <summary>
                        /// 获取或设置买家收件人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_receiver")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_receiver")]
                        public string PostReceiver { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仲裁状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("arbitrate_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status")]
                        public int ArbitrateStatus { get; set; }

                        /// <summary>
                        /// 获取或设置剩余的催发货短信次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("urge_sms_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("urge_sms_cnt")]
                        public int LeftUrgeSMSCount { get; set; }

                        /// <summary>
                        /// 获取或设置售后申请的子订单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_items")]
                        public Types.AftersaleItem[] AftersaleItemList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售后申请的历史记录列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_record_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_record_items")]
                        public Types.AftersaleRecord[] AftersaleRecordList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置售后单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_list")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_list")]
                public Types.Aftersale[] AftersaleList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
