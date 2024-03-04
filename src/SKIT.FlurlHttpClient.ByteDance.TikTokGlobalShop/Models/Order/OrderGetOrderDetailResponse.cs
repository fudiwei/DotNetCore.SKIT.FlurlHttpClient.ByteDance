namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orders/detail/query 接口的响应。</para>
    /// </summary>
    public class OrderGetOrderDetailResponse : TikTokShopResponse<OrderGetOrderDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Order : OrderSearchOrdersResponse.Types.Data.Types.Order
                    {
                        public static class Types
                        {
                            public class PaymentInfo
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置总金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal TotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 总金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sub_total")]
                                [System.Text.Json.Serialization.JsonPropertyName("sub_total")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SubtotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFee { get; set; }

                                /// <summary>
                                /// 获取或设置运费税。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_tax")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_tax")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeTax { get; set; }

                                /// <summary>
                                /// 获取或设置卖家优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SellerDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置商品原价。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_total_product_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_total_product_price")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal OriginalTotalProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置运费原价。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal OriginalShippingFee { get; set; }

                                /// <summary>
                                /// 获取或设置运费卖家优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_seller_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_seller_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeSellerDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置运费平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_platform_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_platform_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeePlatformDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFee { get; set; }

                                /// <summary>
                                /// 获取或设置税费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("taxes")]
                                [System.Text.Json.Serialization.JsonPropertyName("taxes")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal Taxes { get; set; }

                                /// <summary>
                                /// 获取或设置小额订单费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("small_order_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("small_order_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SmallOrderFee { get; set; }

                                /// <summary>
                                /// 获取或设置商品税。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_taxes")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_taxes")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ProductTaxes { get; set; }
                            }

                            public class RecipientAddress
                            {
                                /// <summary>
                                /// 获取或设置完整地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("full_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("full_address")]
                                public string FullAddress { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置国家或地区编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("region_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                                public string RegionCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                                public string PhoneNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置联系人姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string ContactName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置邮编。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("zipcode")]
                                [System.Text.Json.Serialization.JsonPropertyName("zipcode")]
                                public string ZipCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
                                public string AddressDetail { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地址行 1。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("addressline1")]
                                [System.Text.Json.Serialization.JsonPropertyName("addressline1")]
                                public string? AddressLine1 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 2。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("addressline2")]
                                [System.Text.Json.Serialization.JsonPropertyName("addressline2")]
                                public string? AddressLine2 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 3。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("addressline3")]
                                [System.Text.Json.Serialization.JsonPropertyName("addressline3")]
                                public string? AddressLine3 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 4。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("addressline4")]
                                [System.Text.Json.Serialization.JsonPropertyName("addressline4")]
                                public string? AddressLine4 { get; set; }
                            }

                            public class Package
                            {
                                /// <summary>
                                /// 获取或设置包裹 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("package_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string PackageId { get; set; } = default!;
                            }

                            public class DistrictInfo
                            {
                                /// <summary>
                                /// 获取或设置行政区划名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_level_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_level_name")]
                                public string AddressLevelName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置行政区划名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_name")]
                                public string AddressName { get; set; } = default!;
                            }

                            public class OrderLine
                            {
                                public static class Types
                                {
                                    public class ItemTax
                                    {
                                        /// <summary>
                                        /// 获取或设置税费类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tax_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tax_type")]
                                        public int TaxType { get; set; }

                                        /// <summary>
                                        /// 获取或设置税费金额。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tax_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("tax_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal TaxAmount { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_line_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_line_id")]
                                public string OrderLineId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

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
                                /// 获取或设置 SKU 类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_type")]
                                public int SKUType { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_image")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_image")]
                                public string SKUImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置原价。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal OriginalPrice { get; set; }

                                /// <summary>
                                /// 获取或设置售价。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sale_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalePrice { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置卖家优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SellerDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFee { get; set; }

                                /// <summary>
                                /// 获取或设置小额订单费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("small_order_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("small_order_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SmallOrderFee { get; set; }

                                /// <summary>
                                /// 获取或设置显示状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("display_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("display_status")]
                                public int DisplayStatus { get; set; }

                                /// <summary>
                                /// 获取或设置取消者。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cancel_user")]
                                [System.Text.Json.Serialization.JsonPropertyName("cancel_user")]
                                public string? CancelUser { get; set; }

                                /// <summary>
                                /// 获取或设置取消原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cancel_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
                                public string? CancelReason { get; set; }

                                /// <summary>
                                /// 获取或设置准备发货时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rts_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("rts_time")]
                                public long? ReadyToShipTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置运输服务商 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                                public string? ShippingProviderId { get; set; }

                                /// <summary>
                                /// 获取或设置运输服务商名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_provider_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_name")]
                                public string? ShippingProviderName { get; set; }

                                /// <summary>
                                /// 获取或设置物流单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tracking_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                                public string? TrackingNumber { get; set; }

                                /// <summary>
                                /// 获取或设置包裹 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("package_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string? PackageId { get; set; }

                                /// <summary>
                                /// 获取或设置包裹状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("package_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("package_status")]
                                public int? PackageStatus { get; set; }

                                /// <summary>
                                /// 获取或设置包裹冻结状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("package_freeze_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("package_freeze_status")]
                                public int? PackageFreezeStatus { get; set; }

                                /// <summary>
                                /// 获取或设置是否是礼品。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_gift")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_gift")]
                                public bool IsGift { get; set; }

                                /// <summary>
                                /// 获取或设置商品税费列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_tax")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_tax")]
                                public Types.ItemTax[]? ItemTaxList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置支付方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_method")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_method")]
                        public string PaymentMethod { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付方式类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_method_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_method_type")]
                        public int PaymentMethodType { get; set; }

                        /// <summary>
                        /// 获取或设置支付方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_method_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_method_name")]
                        public string? PaymentMethodName { get; set; }

                        /// <summary>
                        /// 获取或设置支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_info")]
                        public Types.PaymentInfo PaymentInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option")]
                        public string DeliveryOption { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_type")]
                        public int DeliveryOptionType { get; set; }

                        /// <summary>
                        /// 获取或设置配送方式描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_description")]
                        public string? DeliveryOptionDescription { get; set; }

                        /// <summary>
                        /// 获取或设置配送方式 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_id")]
                        public string? DeliveryOptionId { get; set; }

                        /// <summary>
                        /// 获取或设置发货 SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_sla")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_sla")]
                        public long? DeliverySLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider")]
                        public string? ShippingProvider { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                        public string? ShippingProviderId { get; set; }

                        /// <summary>
                        /// 获取或设置买家用户 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_uid")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_uid")]
                        public string? BuyerUserId { get; set; }

                        /// <summary>
                        /// 获取或设置买家备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_message")]
                        public string? BuyerMessage { get; set; }

                        /// <summary>
                        /// 获取或设置买家匿名邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_email")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_email")]
                        public string? BuyerEmail { get; set; }

                        /// <summary>
                        /// 获取或设置卖家备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_note")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_note")]
                        public string? SellerNotes { get; set; }

                        /// <summary>
                        /// 获取或设置收货地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recipient_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("recipient_address")]
                        public Types.RecipientAddress RecipientAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收件人地址更新状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_address_updated")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_address_updated")]
                        public int ReceiverAddressUpdatedStatus { get; set; }

                        /// <summary>
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tracking_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                        public string? TrackingNumber { get; set; }

                        /// <summary>
                        /// 获取或设置包裹列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_list")]
                        public Types.Package[]? PackageList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置付款时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                        public long? PaidTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单者。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_user")]
                        public string? CancelUser { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
                        public string? CancelReason { get; set; }

                        /// <summary>
                        /// 获取或设置 RTS 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rts_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("rts_time")]
                        public long? ReadyToShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 RTS SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rts_sla")]
                        [System.Text.Json.Serialization.JsonPropertyName("rts_sla")]
                        public long? ReadyToShipSLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 TTS SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tts_sla")]
                        [System.Text.Json.Serialization.JsonPropertyName("tts_sla")]
                        public long? TikTokShopSLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单 SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_order_sla")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_order_sla")]
                        public long? CancelOrderSLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置合单或拆单标记。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("split_or_combine_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("split_or_combine_tag")]
                        public string? SplitOrCombineTag { get; set; }

                        /// <summary>
                        /// 获取或设置配送类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fulfillment_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("fulfillment_type")]
                        public int? FulfillmentType { get; set; }

                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                        public string? WarehouseId { get; set; }

                        /// <summary>
                        /// 获取或设置是否货到付款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_cod")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_cod")]
                        public bool IsCashOnDelivery { get; set; }

                        /// <summary>
                        /// 获取或设置行政区划列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("district_info_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("district_info_list")]
                        public Types.DistrictInfo[]? DistrictInfoList { get; set; }

                        /// <summary>
                        /// 获取或设置订单行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_line_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_line_list")]
                        public Types.OrderLine[]? OrderLineList { get; set; }

                        /// <summary>
                        /// 获取或设置个人税务登记号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cpf")]
                        [System.Text.Json.Serialization.JsonPropertyName("cpf")]
                        public string? CPFNumber { get; set; }

                        /// <summary>
                        /// 获取或设置需要上传发票状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_upload_invoice")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_upload_invoice")]
                        public int? NeedUploadInvoiceStatus { get; set; }

                        /// <summary>
                        /// 获取或设置是否是示例订单。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_sample_order")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_sample_order")]
                        public bool? IsSampleOrder { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_list")]
                public Types.Order[] OrderList { get; set; } = default!;
            }
        }
    }
}
