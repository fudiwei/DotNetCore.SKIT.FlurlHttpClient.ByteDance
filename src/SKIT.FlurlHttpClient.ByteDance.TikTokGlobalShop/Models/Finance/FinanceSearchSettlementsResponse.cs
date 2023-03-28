namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /finance/settlements/search 接口的响应。</para>
    /// </summary>
    public class FinanceSearchSettlementsResponse : TikTokShopResponse<FinanceSearchSettlementsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Settlement
                    {
                        public static class Types
                        {
                            public class SettlementInfo
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置用户支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_pay")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_pay")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal UserPaidAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台促销金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_promotion")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_promotion")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal PlatformPromotionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal RefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置支付服务费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("payment_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("payment_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal PaymentFee { get; set; }

                                /// <summary>
                                /// 获取或设置交易服务费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal TransactionFee { get; set; }

                                /// <summary>
                                /// 获取或设置固定费用。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flat_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("flat_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal FlatFee { get; set; }

                                /// <summary>
                                /// 获取或设置销售费用。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SalesFee { get; set; }

                                /// <summary>
                                /// 获取或设置 SFP 服务费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sfp_service_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("sfp_service_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SFPServiceFee { get; set; }

                                /// <summary>
                                /// 获取或设置运输费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal ShippingFee { get; set; }

                                /// <summary>
                                /// 获取或设置小额订单费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("small_order_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("small_order_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SmallOrderFee { get; set; }

                                /// <summary>
                                /// 获取或设置平台佣金。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_commission")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal PlatformCommission { get; set; }

                                /// <summary>
                                /// 获取或设置联盟佣金。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal AffiliateCommission { get; set; }

                                /// <summary>
                                /// 获取或设置联盟服务商佣金。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_partner_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_partner_commission")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal AffiliatePartnerCommission { get; set; }

                                /// <summary>
                                /// 获取或设置增值税。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("vat")]
                                [System.Text.Json.Serialization.JsonPropertyName("vat")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal VAT { get; set; }

                                /// <summary>
                                /// 获取或设置商品及服务税。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gst")]
                                [System.Text.Json.Serialization.JsonPropertyName("gst")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal GST { get; set; }

                                /// <summary>
                                /// 获取或设置运输补贴金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_subsidy")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_subsidy")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal ShippingFeeSubsidyAmount { get; set; }

                                /// <summary>
                                /// 获取或设置卖方原因扣除金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_reason_fund_deduction")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_reason_fund_deduction")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SellerReasonFundDeductionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运费调整金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_adjustment")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_adjustment")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal ShippingFeeAdjustmentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置促销调整金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promotion_adjustment")]
                                [System.Text.Json.Serialization.JsonPropertyName("promotion_adjustment")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal PromotionAdjustmentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置其他调整金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("other_adjustment")]
                                [System.Text.Json.Serialization.JsonPropertyName("other_adjustment")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal OtherAdjustmentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置冲正金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("charge_back")]
                                [System.Text.Json.Serialization.JsonPropertyName("charge_back")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal ChargeBackAmount { get; set; }

                                /// <summary>
                                /// 获取或设置客服补偿金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_service_compensation")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_service_compensation")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal CustomerServiceCompensationAmount { get; set; }

                                /// <summary>
                                /// 获取或设置扣除卖家优惠后小计金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("subtotal_after_seller_discounts")]
                                [System.Text.Json.Serialization.JsonPropertyName("subtotal_after_seller_discounts")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SubtotalAfterSellerDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置去除卖家优惠后退款小计金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_subtotal_after_seller_discounts")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_subtotal_after_seller_discounts")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SubtotalAfterSellerDiscountRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置结算金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settlement_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal SettlementAmount { get; set; }

                                /// <summary>
                                /// 获取或设置结算时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settlement_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("settlement_time")]
                                public long SettlementTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置结算 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unique_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("unique_key")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SettlementId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置调整 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjustment_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("adjustment_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string AdjustmentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置关联订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("related_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("related_order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string RelatedOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string? ProductName { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string? SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                        public string? SKUName { get; set; }

                        /// <summary>
                        /// 获取或设置结算信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_info")]
                        public Types.SettlementInfo SettlementInfo { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置结算列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settlement_list")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_list")]
                public Types.Settlement[] SettlementList { get; set; } = default!;

                /// <summary>
                /// 获取或设置下一页分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
                public string? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("more")]
                [System.Text.Json.Serialization.JsonPropertyName("more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
