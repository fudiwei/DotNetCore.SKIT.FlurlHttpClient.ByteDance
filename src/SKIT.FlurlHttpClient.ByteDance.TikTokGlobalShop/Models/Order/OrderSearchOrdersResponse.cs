namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/{version}/orders/search 接口的响应。</para>
    /// </summary>
    public class OrderSearchOrdersResponse : TikTokShopResponse<OrderSearchOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Order
                    {
                        public static class Types
                        {
                            public class Package
                            {
                                /// <summary>
                                /// 获取或设置包裹 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string PackageId { get; set; } = default!;
                            }

                            public class Payment
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
                                [Newtonsoft.Json.JsonProperty("tax")]
                                [System.Text.Json.Serialization.JsonPropertyName("tax")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal Tax { get; set; }

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
                                [Newtonsoft.Json.JsonProperty("product_tax")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_tax")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ProductTax { get; set; }

                                /// <summary>
                                /// 获取或设置买家服务费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("buyer_service_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("buyer_service_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal BuyerServiceFee { get; set; }
                            }

                            public class RecipientAddress
                            {
                                public static class Types
                                {
                                    public class DistrictInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置行政区划级别。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("address_level")]
                                        [System.Text.Json.Serialization.JsonPropertyName("address_level")]
                                        public string AddressLevel { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置行政区划级别名称。
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

                                    public class DeliveryPreferences
                                    {
                                        /// <summary>
                                        /// 获取或设置归还地点。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("drop_off_location")]
                                        [System.Text.Json.Serialization.JsonPropertyName("drop_off_location")]
                                        public string DropOffLocation { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置完整地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("full_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("full_address")]
                                public string FullAddress { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地区编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("region_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                                public string RegionCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
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
                                [Newtonsoft.Json.JsonProperty("postal_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                                public string PostalCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
                                public string AddressDetail { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地址行 1。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line1")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line1")]
                                public string? AddressLine1 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 2。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line2")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line2")]
                                public string? AddressLine2 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 3。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line3")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line3")]
                                public string? AddressLine3 { get; set; }

                                /// <summary>
                                /// 获取或设置地址行 4。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_line4")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_line4")]
                                public string? AddressLine4 { get; set; }

                                /// <summary>
                                /// 获取或设置行政区划信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("district_info")]
                                public Types.DistrictInfo[]? DistrictInfoList { get; set; }

                                /// <summary>
                                /// 获取或设置配送首选项。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_preferences")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_preferences")]
                                public Types.DeliveryPreferences? DeliveryPreferences { get; set; }
                            }

                            public class LineItem
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
                                        public string TaxType { get; set; } = default!;

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
                                    }
                                }

                                /// <summary>
                                /// 获取或设置订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string LineItemId { get; set; } = default!;

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
                                public string SKUType { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_image")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_image")]
                                public string SKUImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

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
                                /// 获取或设置买家服务费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("buyer_service_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("buyer_service_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal BuyerServiceFee { get; set; }

                                /// <summary>
                                /// 获取或设置显示状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("display_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("display_status")]
                                public string DisplayStatus { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置取消发起人。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cancel_user")]
                                [System.Text.Json.Serialization.JsonPropertyName("cancel_user")]
                                public string? CancelRole { get; set; }

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
                                public string? PackageStatus { get; set; }

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

                                /// <summary>
                                /// 获取或设置组合 SKU 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("combined_listing_skus")]
                                [System.Text.Json.Serialization.JsonPropertyName("combined_listing_skus")]
                                public CombinedListingSKU[]? CombinedListingSKUList { get; set; }
                            }

                            public class CombinedListingSKU : LineItem
                            {
                                /// <summary>
                                /// 获取或设置 SKU 数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_count")]
                                public int SKUCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置支付方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_method_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_method_name")]
                        public string? PaymentMethodName { get; set; }

                        /// <summary>
                        /// 获取或设置支付信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment")]
                        public Types.Payment Payment { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置买家用户 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                        public string? BuyerUserId { get; set; }

                        /// <summary>
                        /// 获取或设置买家匿名邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_email")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_email")]
                        public string? BuyerEmail { get; set; }

                        /// <summary>
                        /// 获取或设置买家留言。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_message")]
                        public string? BuyerMessage { get; set; }

                        /// <summary>
                        /// 获取或设置卖家备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_note")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_note")]
                        public string? SellerNotes { get; set; }

                        /// <summary>
                        /// 获取或设置订单行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("line_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("line_items")]
                        public Types.LineItem[]? LineItemList { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                        public string? ShippingProviderId { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider")]
                        public string? ShippingProviderName { get; set; }

                        /// <summary>
                        /// 获取或设置收货地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recipient_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("recipient_address")]
                        public Types.RecipientAddress RecipientAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否已更改收货地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_updated_recipient_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("has_updated_recipient_address")]
                        public bool HasUpdatedRecipientAddress { get; set; }

                        /// <summary>
                        /// 获取或设置履约类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fulfillment_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("fulfillment_type")]
                        public string? FulfillmentType { get; set; }

                        /// <summary>
                        /// 获取或设置配送类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_type")]
                        public string? DeliveryType { get; set; }

                        /// <summary>
                        /// 获取或设置配送方式 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_id")]
                        public string? DeliveryOptionId { get; set; }

                        /// <summary>
                        /// 获取或设置配送方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_name")]
                        public string? DeliveryOptionName { get; set; }

                        /// <summary>
                        /// 获取或设置配送截止日期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_due_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_due_time")]
                        public long? DeliveryDueTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置配送方式所需时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_required_delivery_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_required_delivery_time")]
                        public long? DeliveryOptionRequiredDeliveryTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置配送时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                        public long? DeliveryTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置发货方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_type")]
                        public string? ShippingType { get; set; }

                        /// <summary>
                        /// 获取或设置发货截止日期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_due_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_due_time")]
                        public long? ShippingDueTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置揽货截止日期时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("collection_due_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("collection_due_time")]
                        public long? CollectionDueTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置揽货时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("collection_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("collection_time")]
                        public long? CollectionTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tracking_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                        public string? TrackingNumber { get; set; }

                        /// <summary>
                        /// 获取或设置合单或拆单标记。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("split_or_combine_tag")]
                        [System.Text.Json.Serialization.JsonPropertyName("split_or_combine_tag")]
                        public string? SplitOrCombineTag { get; set; }

                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                        public string? WarehouseId { get; set; }

                        /// <summary>
                        /// 获取或设置包裹列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("packages")]
                        [System.Text.Json.Serialization.JsonPropertyName("packages")]
                        public Types.Package[]? PackageList { get; set; }

                        /// <summary>
                        /// 获取或设置付款时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                        public long? PaidTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 RTS 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rts_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("rts_time")]
                        public long? ReadyToShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 RTS SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("rts_sla_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("rts_sla_time")]
                        public long? ReadyToShipSLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 TTS SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tts_sla_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("tts_sla_time")]
                        public long? TikTokShopSLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置发货 SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_sla_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_sla_time")]
                        public long? DeliverySLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否货到付款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_cod")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_cod")]
                        public bool IsCashOnDelivery { get; set; }

                        /// <summary>
                        /// 获取或设置取消发起人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancellation_initiator")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancellation_initiator")]
                        public string? CancelRole { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
                        public string? CancelReason { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单 SLA 时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_order_sla_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_order_sla_time")]
                        public long? CancelOrderSLATimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                        public long? CancelTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置请求取消订单时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("request_cancel_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("request_cancel_time")]
                        public long? RequestCancelTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置买家是否请求取消订单。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_buyer_request_cancel")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_buyer_request_cancel")]
                        public bool? IsBuyerRequestCancel { get; set; }

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
                        public string? NeedUploadInvoiceStatus { get; set; }

                        /// <summary>
                        /// 获取或设置是否是示例订单。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_sample_order")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_sample_order")]
                        public bool? IsSampleOrder { get; set; }

                        /// <summary>
                        /// 获取或设置是否是延期订单。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_on_hold_order")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_on_hold_order")]
                        public bool? IsOnHoldOrder { get; set; }

                        /// <summary>
                        /// 获取或设置是否是替代订单。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_replacement_order")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_replacement_order")]
                        public bool? IsReplacementOrder { get; set; }

                        /// <summary>
                        /// 获取或设置替代订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("replaced_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("replaced_order_id")]
                        public string? ReplacedOrderId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orders")]
                [System.Text.Json.Serialization.JsonPropertyName("orders")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
