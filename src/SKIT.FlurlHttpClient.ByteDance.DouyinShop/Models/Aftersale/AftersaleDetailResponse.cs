using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/Detail 接口的响应。</para>
    /// </summary>
    public class AftersaleDetailResponse : DouyinShopResponse<AftersaleDetailResponse.Types.Data>
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
                            public class Detail
                            {
                                public static class Types
                                {
                                    public class SKUExchange : AftersaleListResponse.Types.Data.Types.Aftersale.Types.Detail.Types.SKUExchange
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string AftersaleId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置用户申请售后件数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_apply_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_apply_count")]
                                public int ApplyCount { get; set; }

                                /// <summary>
                                /// 获取或设置申请时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("apply_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                public DateTimeOffset ApplyTime { get; set; }

                                /// <summary>
                                /// 获取或设置售后类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_type")]
                                public int? AftersaleType { get; set; }

                                /// <summary>
                                /// 获取或设置售后类型描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_type_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_type_text")]
                                public string AftersaleTypeDescription { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置超时自动流转截止时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status_deadline")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("status_deadline")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? StatusDeadlineTime { get; set; }

                                /// <summary>
                                /// 获取或设置售后原因类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                                public int ReasonCode { get; set; }

                                /// <summary>
                                /// 获取或设置售后原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                public string Reason { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后原因备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason_remark")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason_remark")]
                                public string? ReasonRemark { get; set; }

                                /// <summary>
                                /// 获取或设置售后状态类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_status")]
                                public int AftersaleStatus { get; set; }

                                /// <summary>
                                /// 获取或设置实际退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("real_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("real_refund_amount")]
                                public int ActualRefundmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_total_amount")]
                                public int RefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款运费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_post_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_post_amount")]
                                public int RefundPostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款税费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_tax_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_tax_amount")]
                                public int RefundTaxAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_promotion_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_promotion_amount")]
                                public int RefundPromotionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
                                public int RefundType { get; set; }

                                /// <summary>
                                /// 获取或设置退款类型描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_type_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_type_text")]
                                public string RefundTypeDescription { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退款状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                                public int RefundStatus { get; set; }

                                /// <summary>
                                /// 获取或设置凭证 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("evidence")]
                                [System.Text.Json.Serialization.JsonPropertyName("evidence")]
                                public string[]? EvidenceUrlList { get; set; }

                                /// <summary>
                                /// 获取或设置部分退款类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("part_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("part_type")]
                                public int RefundPartType { get; set; }

                                /// <summary>
                                /// 获取或设置退货物流单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_logistics_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_logistics_code")]
                                public string? ReturnLogisticsNumber { get; set; }

                                /// <summary>
                                /// 获取或设置退优惠金额金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_promotion_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_promotion_amount")]
                                public int ReturnPromotionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status")]
                                public int ArbitrateStatus { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁责任方类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_blame")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_blame")]
                                public int ArbitrateBlameType { get; set; }

                                /// <summary>
                                /// 获取或设置剩余的催发货短信次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("left_urge_sms_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("left_urge_sms_count")]
                                public int LeftUrgeSMSCount { get; set; }

                                /// <summary>
                                /// 获取或设置创建时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                public DateTimeOffset CreateTime { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                public DateTimeOffset UpdateTime { get; set; }

                                /// <summary>
                                /// 获取或设置风控码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("risk_decision_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("risk_decision_code")]
                                public int RiskDecisionCode { get; set; }

                                /// <summary>
                                /// 获取或设置风控理由。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("risk_decision_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("risk_decision_reason")]
                                public string? RiskDecisionReason { get; set; }

                                /// <summary>
                                /// 获取或设置风控描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("risk_decision_description")]
                                [System.Text.Json.Serialization.JsonPropertyName("risk_decision_description")]
                                public string? RiskDecisionDescription { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 换货信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("exchange_sku_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("exchange_sku_info")]
                                public Types.SKUExchange? SKUExchange { get; set; }
                            }

                            public class Arbitrate
                            {
                                public static class Types
                                {
                                    public class Evidence
                                    {
                                        /// <summary>
                                        /// 获取或设置证据图片 URL 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("images")]
                                        [System.Text.Json.Serialization.JsonPropertyName("images")]
                                        public string[] ImageUrlList { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置证据描述。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("describe")]
                                        [System.Text.Json.Serialization.JsonPropertyName("describe")]
                                        public string? Description { get; set; }
                                    }

                                    public class EvidenceTemplate : Evidence
                                    {
                                        /// <summary>
                                        /// 获取或设置截止时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("dead_line")]
                                        [System.Text.Json.Serialization.JsonPropertyName("dead_line")]
                                        public long DeadlineTimestamp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置仲裁单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string ArbitrateId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置仲裁单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status")]
                                public int ArbitrateStatus { get; set; }

                                /// <summary>
                                /// 获取或设置是否需要上传凭证。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_required_evidence")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("is_required_evidence")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                                public bool RequiredEvidence { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁截止时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_status_deadline")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status_deadline")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? StatusDeadlineTime { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_opinion")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_opinion")]
                                public string Opinion { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置仲裁结果编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_conclusion")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_conclusion")]
                                public int ConclusionCode { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁责任方类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_blame")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_blame")]
                                public int ArbitrateBlameType { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁证据示例。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_evidence_tmpl")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_evidence_tmpl")]
                                public Types.EvidenceTemplate? EvidenceTemplate { get; set; }

                                /// <summary>
                                /// 获取或设置仲裁证据。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_evidence")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_evidence")]
                                public Types.Evidence? Evidence { get; set; }

                                /// <summary>
                                /// 获取或设置创建时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_create_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_create_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                public DateTimeOffset CreateTime { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_update_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_update_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                                public DateTimeOffset UpdateTime { get; set; }
                            }

                            public class ServiceTag
                            {
                                public static class Types
                                {
                                    public class Tag : AftersaleListResponse.Types.Data.Types.Aftersale.Types.Order.Types.SKUOrder.Types.Tag
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置标签列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_service_tag")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_service_tag")]
                                public Types.Tag[] TagList { get; set; } = default!;
                            }

                            public class Logistics
                            {
                                public static class Types
                                {
                                    public class ReturnLogistics
                                    {
                                        /// <summary>
                                        /// 获取或设置物流单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tracking_no")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
                                        public string LogisticsNumber { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置物流公司编码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("company_code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("company_code")]
                                        public string CompanyCode { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置物流公司名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("company_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                                        public string CompanyName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置发出时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("logistics_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("logistics_time")]
                                        public long LogisticsTimestamp { get; set; }
                                    }

                                    public class ExchangeLogistics : ReturnLogistics
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置买家退货物流信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return")]
                                [System.Text.Json.Serialization.JsonPropertyName("return")]
                                public Types.ReturnLogistics? ReturnLogistics { get; set; }

                                /// <summary>
                                /// 获取或设置卖家换货物流信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("exchange")]
                                [System.Text.Json.Serialization.JsonPropertyName("exchange")]
                                public Types.ExchangeLogistics? ExchangeLogistics { get; set; }
                            }

                            public class ShopRemark
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
                                [Newtonsoft.Json.JsonProperty("after_sale_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string AftersaleId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作人姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("operator")]
                                [System.Text.Json.Serialization.JsonPropertyName("operator")]
                                public string OperatorName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置备注内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("remark")]
                                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                                public string Remark { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置售后单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_info")]
                        public Types.Detail Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仲裁信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("arbitrate_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("arbitrate_info")]
                        public Types.Arbitrate? Arbitrate { get; set; }

                        /// <summary>
                        /// 获取或设置售后标签信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_service_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_service_tag")]
                        public Types.ServiceTag? ServiceTag { get; set; }

                        /// <summary>
                        /// 获取或设置物流信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_info")]
                        public Types.Logistics? Logistics { get; set; }

                        /// <summary>
                        /// 获取或设置店铺备注列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_sale_shop_remarks")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_sale_shop_remarks")]
                        public Types.ShopRemark[]? ShopRemarkList { get; set; }
                    }

                    public class Order
                    {
                        public static class Types
                        {
                            public class SKUOrder
                            {
                                public static class Types
                                {
                                    public class Tag : AftersaleListResponse.Types.Data.Types.Aftersale.Types.Order.Types.SKUOrder.Types.Tag
                                    {
                                    }

                                    public class Specification : AftersaleListResponse.Types.Data.Types.Aftersale.Types.Order.Types.SKUOrder.Types.Specification
                                    {
                                    }

                                    public class GivenSKUDetail : AftersaleListResponse.Types.Data.Types.Aftersale.Types.Order.Types.SKUOrder.Types.GivenSKUDetail
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_order_id")]
                                public string SKUOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                                public int OrderStatus { get; set; }

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
                                /// 获取或设置商品图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_image")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_image")]
                                public string ProductImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_sku_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_sku_code")]
                                public string SKUCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置标签列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tags")]
                                [System.Text.Json.Serialization.JsonPropertyName("tags")]
                                public Types.Tag[]? TagList { get; set; }

                                /// <summary>
                                /// 获取或设置保险标签列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("insurance_tags")]
                                [System.Text.Json.Serialization.JsonPropertyName("insurance_tags")]
                                public Types.Tag[]? InsuranceTagList { get; set; }

                                /// <summary>
                                /// 获取或设置规格列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_spec")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_spec")]
                                public Types.Specification[]? SpecificationList { get; set; }

                                /// <summary>
                                /// 获取或设置赠品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("given_sku_details")]
                                [System.Text.Json.Serialization.JsonPropertyName("given_sku_details")]
                                public Types.GivenSKUDetail[]? GivenSKUDetail { get; set; }

                                /// <summary>
                                /// 获取或设置支付方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                                public int PayType { get; set; }

                                /// <summary>
                                /// 获取或设置付款金额（单位：分）。
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
                                /// 获取或设置税费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tax_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("tax_amount")]
                                public int TaxAmount { get; set; }

                                /// <summary>
                                /// 获取或设置优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promotion_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("promotion_amount")]
                                public int PromotionPayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 总原价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_sum_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_sum_amount")]
                                public int SKUSumAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_pay_amount")]
                                public int SKUPayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置购买数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_quantity")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置是否为海外订单。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_oversea_order")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("is_oversea_order")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                                public bool IsOverseaOrder { get; set; }

                                /// <summary>
                                /// 获取或设置下单时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置售后商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_sale_item_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_sale_item_count")]
                                public int AftersaleCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
                        public string ShopOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_order_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_order_infos")]
                        public Types.SKUOrder[] SKUOrderList { get; set; } = default!;
                    }

                }

                /// <summary>
                /// 获取或设置售后单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("process_info")]
                [System.Text.Json.Serialization.JsonPropertyName("process_info")]
                public Types.Aftersale Aftersale { get; set; } = default!;

                /// <summary>
                /// 获取或设置关联订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_info")]
                [System.Text.Json.Serialization.JsonPropertyName("order_info")]
                public Types.Order Order { get; set; } = default!;
            }
        }
    }
}
