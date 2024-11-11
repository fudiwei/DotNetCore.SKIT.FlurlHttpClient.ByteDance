namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /order/{version}/orders/{order_id}/price_detail 接口的响应。</para>
    /// </summary>
    public class OrderGetOrderPriceDetailResponse : TikTokShopResponse<OrderGetOrderPriceDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LineItem
                    {
                        /// <summary>
                        /// 获取或设置订单行 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string LineItemId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置总金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total")]
                        [System.Text.Json.Serialization.JsonPropertyName("total")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal TotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 原价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_list_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_list_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SKUListPrice { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 现价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_sale_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_sale_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SKUSalePrice { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 总金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subtotal")]
                        [System.Text.Json.Serialization.JsonPropertyName("subtotal")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SubtotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 卖家折扣金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subtotal_deduction_seller")]
                        [System.Text.Json.Serialization.JsonPropertyName("subtotal_deduction_seller")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SubtotalAmountSellerDeduction { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 平台折扣金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subtotal_deduction_platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("subtotal_deduction_platform")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SubtotalAmountPlatformDeduction { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 税费。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subtotal_tax_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("subtotal_tax_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SubtotalTaxAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商家促销金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("voucher_deduction_seller")]
                        [System.Text.Json.Serialization.JsonPropertyName("voucher_deduction_seller")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal VoucherAmountSellerDeduction { get; set; }

                        /// <summary>
                        /// 获取或设置平台促销类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("voucher_deduction_platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("voucher_deduction_platform")]
                        public string? VoucherPlatformDeductionType { get; set; }

                        /// <summary>
                        /// 获取或设置运费原价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_list_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_list_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingListPrice { get; set; }

                        /// <summary>
                        /// 获取或设置运费现价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_sale_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_sale_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingSalePrice { get; set; }

                        /// <summary>
                        /// 获取或设置商家运费折扣金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_deduction_seller")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_deduction_seller")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeeSellerDeduction { get; set; }

                        /// <summary>
                        /// 获取或设置平台运费折扣金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_deduction_platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_deduction_platform")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeePlatformDeduction { get; set; }

                        /// <summary>
                        /// 获取或设置平台促销运费折扣金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_deduction_platform_voucher")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_deduction_platform_voucher")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeePlatformVoucherDeduction { get; set; }

                        /// <summary>
                        /// 获取或设置税率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_rate")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal TaxRate { get; set; }

                        /// <summary>
                        /// 获取或设置税费。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal TaxAmount { get; set; }

                        /// <summary>
                        /// 获取或设置不含税金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("net_price_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("net_price_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal NetPriceAmount { get; set; }

                        /// <summary>
                        /// 获取或设置货到付款费用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cod_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("cod_fee")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? CashOnDeliveryFee { get; set; }

                        /// <summary>
                        /// 获取或设置不含税货到付款费用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cod_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("cod_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? NetCashOnDeliveryFee { get; set; }

                        /// <summary>
                        /// 获取或设置赠品原价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_gift_original_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_gift_original_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SKUGiftOriginalPrice { get; set; }

                        /// <summary>
                        /// 获取或设置赠品不含税价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_gift_net_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_gift_net_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SKUGiftNetPrice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = default!;

                /// <summary>
                /// 获取或设置总金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置支付金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment")]
                [System.Text.Json.Serialization.JsonPropertyName("payment")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal PaymentAmount { get; set; }

                /// <summary>
                /// 获取或设置 SKU 原价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_list_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_list_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SKUListPrice { get; set; }

                /// <summary>
                /// 获取或设置 SKU 现价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_sale_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_sale_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SKUSalePrice { get; set; }

                /// <summary>
                /// 获取或设置 SKU 总金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subtotal")]
                [System.Text.Json.Serialization.JsonPropertyName("subtotal")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SubtotalAmount { get; set; }

                /// <summary>
                /// 获取或设置 SKU 卖家折扣金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subtotal_deduction_seller")]
                [System.Text.Json.Serialization.JsonPropertyName("subtotal_deduction_seller")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SubtotalAmountSellerDeduction { get; set; }

                /// <summary>
                /// 获取或设置 SKU 平台折扣金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subtotal_deduction_platform")]
                [System.Text.Json.Serialization.JsonPropertyName("subtotal_deduction_platform")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SubtotalAmountPlatformDeduction { get; set; }

                /// <summary>
                /// 获取或设置 SKU 税费。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subtotal_tax_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("subtotal_tax_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SubtotalTaxAmount { get; set; }

                /// <summary>
                /// 获取或设置商家促销金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_deduction_seller")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_deduction_seller")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal VoucherAmountSellerDeduction { get; set; }

                /// <summary>
                /// 获取或设置平台促销类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("voucher_deduction_platform")]
                [System.Text.Json.Serialization.JsonPropertyName("voucher_deduction_platform")]
                public string? VoucherPlatformDeductionType { get; set; }

                /// <summary>
                /// 获取或设置运费原价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_list_price")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_list_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal ShippingListPrice { get; set; }

                /// <summary>
                /// 获取或设置运费现价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_sale_price")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_sale_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal ShippingSalePrice { get; set; }

                /// <summary>
                /// 获取或设置商家运费折扣金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_fee_deduction_seller")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_deduction_seller")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal ShippingFeeSellerDeduction { get; set; }

                /// <summary>
                /// 获取或设置平台运费折扣金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_fee_deduction_platform")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_deduction_platform")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal ShippingFeePlatformDeduction { get; set; }

                /// <summary>
                /// 获取或设置平台促销运费折扣金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_fee_deduction_platform_voucher")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_deduction_platform_voucher")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal ShippingFeePlatformVoucherDeduction { get; set; }

                /// <summary>
                /// 获取或设置税率。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal TaxRate { get; set; }

                /// <summary>
                /// 获取或设置税费。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal TaxAmount { get; set; }

                /// <summary>
                /// 获取或设置不含税金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("net_price_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("net_price_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal NetPriceAmount { get; set; }

                /// <summary>
                /// 获取或设置货到付款费用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cod_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("cod_fee")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal? CashOnDeliveryFee { get; set; }

                /// <summary>
                /// 获取或设置不含税货到付款费用。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cod_fee_net_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("cod_fee_net_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal? NetCashOnDeliveryFee { get; set; }

                /// <summary>
                /// 获取或设置赠品原价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_gift_original_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_gift_original_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SKUGiftOriginalPrice { get; set; }

                /// <summary>
                /// 获取或设置赠品不含税价格。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_gift_net_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_gift_net_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal SKUGiftNetPrice { get; set; }

                /// <summary>
                /// 获取或设置订单行列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("line_items")]
                [System.Text.Json.Serialization.JsonPropertyName("line_items")]
                public Types.LineItem[] LineItemList { get; set; } = default!;
            }
        }
    }
}
