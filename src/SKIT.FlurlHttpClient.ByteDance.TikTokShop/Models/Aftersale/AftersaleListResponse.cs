using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/List 接口的响应。</para>
    /// </summary>
    public class AftersaleListResponse : TikTokShopResponse<AftersaleListResponse.Types.Data>
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
                                    public class SKUExchange
                                    {
                                        /// <summary>
                                        /// 获取或设置 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                        public long SKUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置外部 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                        public long? OutSKUId { get; set; }

                                        /// <summary>
                                        /// 获取或设置 SKU 编码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                                        public string SKUCode { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置 SKU 名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string SKUName { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置 SKU 图片 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                        public string SKUImageUrl { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置规格描述。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("spec_desc")]
                                        [System.Text.Json.Serialization.JsonPropertyName("spec_desc")]
                                        public string SpecificationDescription { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置外部仓库 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("out_warehouse_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("out_warehouse_id")]
                                        public string OutWarehouseId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置供应商 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("supplier_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                                        public string? SupplierId { get; set; }

                                        /// <summary>
                                        /// 获取或设置单价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                                        public int Price { get; set; }

                                        /// <summary>
                                        /// 获取或设置换货数目。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                                        public int Count { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("related_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("related_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string OrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置订单类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_order_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_order_type")]
                                public int OrderType { get; set; }

                                /// <summary>
                                /// 获取或设置售后单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string AftersaleId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置用户申请售后件数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_num")]
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
                                [Newtonsoft.Json.JsonProperty("aftersale_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_type")]
                                public int AftersaleType { get; set; }

                                /// <summary>
                                /// 获取或设置超时自动流转截止时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status_deadline")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("status_deadline")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? StatusDeadlineTime { get; set; }

                                /// <summary>
                                /// 获取或设置售后原因编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                                public int ReasonCode { get; set; }

                                /// <summary>
                                /// 获取或设置售后状态类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_status")]
                                public int AftersaleStatus { get; set; }

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
                                /// 获取或设置退税金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_tax_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_tax_amount")]
                                public int RefundTaxAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
                                public int RefundType { get; set; }

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

                            public class Order
                            {
                                public static class Types
                                {
                                    public class SKUOrder
                                    {
                                        public static class Types
                                        {
                                            public class Tag
                                            {
                                                /// <summary>
                                                /// 获取或设置标签中文名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("tag_detail")]
                                                [System.Text.Json.Serialization.JsonPropertyName("tag_detail")]
                                                public string Detail { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置标签英文名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("tag_detail_en")]
                                                [System.Text.Json.Serialization.JsonPropertyName("tag_detail_en")]
                                                public string DetailEnglish { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置标签链接。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("tag_link_url")]
                                                [System.Text.Json.Serialization.JsonPropertyName("tag_link_url")]
                                                public string LinkUrl { get; set; } = default!;
                                            }

                                            public class Specification
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

                                            public class GivenSKUDetail
                                            {
                                                /// <summary>
                                                /// 获取或设置赠品名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("product_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                                public string ProductName { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置赠品订单号。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("sku_order_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("sku_order_id")]
                                                public string SKUOrderId { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置商品单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("order_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
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
                                        [Newtonsoft.Json.JsonProperty("promotion_pay_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("promotion_pay_amount")]
                                        public int PromotionPayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置单价（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                                        public int Price { get; set; }

                                        /// <summary>
                                        /// 获取或设置购买数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("item_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("item_num")]
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
                                        /// 获取或设置物流单号。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("logistics_code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                                        public string LogisticsNumber { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置售后退款金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("aftersale_pay_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_pay_amount")]
                                        public int AftersalePayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置售后退运费金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("aftersale_post_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_post_amount")]
                                        public int AftersalePostAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置售后退税金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("aftersale_tax_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_tax_amount")]
                                        public int AftersaleTaxAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置售后商品数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("aftersale_item_num")]
                                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_item_num")]
                                        public int AftersaleCount { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置店铺订单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                public string ShopOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品单列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("related_order_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("related_order_info")]
                                public Types.SKUOrder[] SKUOrderList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置订单标识。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_flag")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_flag")]
                                public int OrderFlag { get; set; }
                            }

                            public class TextPart
                            {
                                /// <summary>
                                /// 获取或设置正向物流发货状态文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("logistics_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("logistics_text")]
                                public string LogisticsText { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后状态文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_status_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_status_text")]
                                public string AftersaleStatusText { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后类型文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("aftersale_type_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("aftersale_type_text")]
                                public string AftersaleTypeText { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退货物流发货状态文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_logistics_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_logistics_text")]
                                public string ReturnLogisticsText { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售后理由文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason_text")]
                                public string ReasonText { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置坏单比例文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bad_item_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("bad_item_text")]
                                public string BadItemText { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置仲裁状态文案。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("arbitrate_status_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status_text")]
                                public string ArbitrateStatusText { get; set; } = default!;
                            }

                            public class SellerLog
                            {
                                /// <summary>
                                /// 获取或设置内容。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string Content { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置星标。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("star")]
                                [System.Text.Json.Serialization.JsonPropertyName("star")]
                                public int Star { get; set; }

                                /// <summary>
                                /// 获取或设置操作者姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("op_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("op_name")]
                                public string OperatorName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset CreateTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置售后单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_info")]
                        public Types.Detail Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
                        public Types.Order Order { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文案信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text_part")]
                        [System.Text.Json.Serialization.JsonPropertyName("text_part")]
                        public Types.TextPart TextPart { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家日志列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_logs")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_logs")]
                        public Types.SellerLog[] SellerLogList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置售后单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public Types.Aftersale[] AftersaleList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int PageSize { get; set; }
            }
        }
    }
}
