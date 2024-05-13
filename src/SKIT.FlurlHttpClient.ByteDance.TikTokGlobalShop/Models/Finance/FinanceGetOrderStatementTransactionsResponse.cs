namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /finance/{version}/orders/{order_id}/statement_transactions 接口的响应。</para>
    /// </summary>
    public class FinanceGetOrderStatementTransactionsResponse : TikTokShopResponse<FinanceGetOrderStatementTransactionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Transaction
                    {
                        public static class Types
                        {
                            public class SKUTransaction
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                                public string SKUName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置产品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置结算金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settlement_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SettlementAmount { get; set; }

                                /// <summary>
                                /// 获取或设置收入金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("revenue_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RevenueAmount { get; set; }

                                /// <summary>
                                /// 获取或设置费用金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal FeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置违约金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("adjustment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("adjustment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AdjustmentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_payment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_payment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerPaymentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置卖家折扣后小计金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_seller_discounts_subtotal_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_seller_discounts_subtotal_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AfterSellerDiscountsSubtotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置增值税金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_tax_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_tax_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalesTaxAmount { get; set; }

                                /// <summary>
                                /// 获取或设置增值税支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_tax_payment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_tax_payment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalesTaxPaymentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置增值税退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_tax_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_tax_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalesTaxRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformDiscountRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家订单退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_order_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_order_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerOrderRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台退款补贴金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_refund_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_refund_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformRefundSubsidyAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费补贴金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeSubsidyAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家运输金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台运输费优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_shipping_fee_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_shipping_fee_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformShippingFeeDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费实际金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ActualShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退单运输费实际金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ActualReturnShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee_payment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_payment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFeePaymentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFeeRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置附属机构佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliateCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置附属合作伙伴佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_partner_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_partner_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliatePartnerCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置附属机构佣金税前金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_commission_before_pit")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_before_pit")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliateCommissionAmountBeforePit { get; set; }

                                /// <summary>
                                /// 获取或设置个人所得税金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pit_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pit_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PitAmount { get; set; }

                                /// <summary>
                                /// 获取或设置交易费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal TransactionFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置转介费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("referral_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("referral_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ReferralFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款管理费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_administration_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_administration_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundAdministrationFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 运费费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fbm_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fbm_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingCostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 平台运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fbt_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fbt_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformShippingCostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 运费优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingCostDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 退货运费优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundShippingCostDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置签字确认费用金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("signature_confirmation_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("signature_confirmation_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SignatureConfirmationFeeAmount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置交易 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string TransactionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置交易状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statement_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("statement_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string StatementId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statement_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("statement_time")]
                        public long StatementTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SettlementAmount { get; set; }

                        /// <summary>
                        /// 获取或设置收入金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("revenue_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RevenueAmount { get; set; }

                        /// <summary>
                        /// 获取或设置费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置违约金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjustment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("adjustment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AdjustmentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_payment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_payment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerPaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置卖家折扣后小计金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_seller_discounts_subtotal_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_seller_discounts_subtotal_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AfterSellerDiscountsSubtotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置增值税金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_tax_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_tax_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SalesTaxAmount { get; set; }

                        /// <summary>
                        /// 获取或设置增值税支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_tax_payment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_tax_payment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SalesTaxPaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置增值税退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_tax_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_tax_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SalesTaxRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformDiscountRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家订单退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_order_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_order_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerOrderRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台退款补贴金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_refund_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_refund_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformRefundSubsidyAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运输费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运输费补贴金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeeSubsidyAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家运输金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台运输费优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_shipping_fee_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_shipping_fee_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformShippingFeeDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运输费实际金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ActualShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退单运输费实际金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_return_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_return_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ActualReturnShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置零售配送费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retail_delivery_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RetailDeliveryFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置零售配送费支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retail_delivery_fee_payment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_payment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RetailDeliveryFeePaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置零售配送费退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retail_delivery_fee_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RetailDeliveryFeeRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置附属机构佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliateCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置附属合作伙伴佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_partner_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_partner_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliatePartnerCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置附属机构佣金税前金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_commission_before_pit")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_before_pit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliateCommissionAmountBeforePit { get; set; }

                        /// <summary>
                        /// 获取或设置个人所得税金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pit_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pit_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PitAmount { get; set; }

                        /// <summary>
                        /// 获取或设置交易费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal TransactionFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置转介费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("referral_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("referral_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ReferralFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款管理费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_administration_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_administration_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RefundAdministrationFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 运费费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbm_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbm_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 平台运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbt_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbt_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformShippingCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 运费优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingCostDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 退货运费优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RefundShippingCostDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置签字确认费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("signature_confirmation_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("signature_confirmation_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SignatureConfirmationFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 交易列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_statement_transactions")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_statement_transactions")]
                        public Types.SKUTransaction[] SKUTransactionList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public long OrderCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置交易列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("statement_transactions")]
                [System.Text.Json.Serialization.JsonPropertyName("statement_transactions")]
                public Types.Transaction[] TransactionList { get; set; } = default!;
            }
        }
    }
}
