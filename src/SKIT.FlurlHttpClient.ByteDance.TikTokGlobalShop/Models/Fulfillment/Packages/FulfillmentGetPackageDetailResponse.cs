namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/packages/{package_id} 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetPackageDetailResponse : TikTokShopResponse<FulfillmentGetPackageDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PackageDimension : ProductGetProductDetailResponse.Types.Data.Types.PackageDimension
                    {
                    }

                    public class PackageWeight : ProductGetProductDetailResponse.Types.Data.Types.PackageWeight
                    {
                    }

                    public class Order
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                public string ImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }
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
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }

                    public class TimeSlot
                    {
                        /// <summary>
                        /// 获取或设置开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }
                    }

                    public class Address
                    {
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
                    }
                }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单行 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_line_item_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("order_line_item_ids")]
                public string[]? OrderLineItemIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orders")]
                [System.Text.Json.Serialization.JsonPropertyName("orders")]
                public Types.Order[]? OrderList { get; set; }

                /// <summary>
                /// 获取或设置包裹。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_status")]
                [System.Text.Json.Serialization.JsonPropertyName("package_status")]
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
                /// 获取或设置分合单标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("split_and_combine_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("split_and_combine_tag")]
                public string SplitAndCombineTag { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("note_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("note_tag")]
                public string NoteTag { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否包含多个 SKU。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_multi_skus")]
                [System.Text.Json.Serialization.JsonPropertyName("has_multi_skus")]
                public bool HasMultipleSKU { get; set; } 

                /// <summary>
                /// 获取或设置运输类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_type")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_type")]
                public string ShippingType { get; set; } = default!;

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
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                public string? TrackingNumber { get; set; }

                /// <summary>
                /// 获取或设置交接方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("handover_method")]
                [System.Text.Json.Serialization.JsonPropertyName("handover_method")]
                public string? HandoverNethod { get; set; }

                /// <summary>
                /// 获取或设置包裹尺寸信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dimension")]
                [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                public Types.PackageDimension? PackageDimension { get; set; }

                /// <summary>
                /// 获取或设置包裹重量信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public Types.PackageWeight? PackageWeight { get; set; }

                /// <summary>
                /// 获取或设置取件时间段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pickup_slot")]
                [System.Text.Json.Serialization.JsonPropertyName("pickup_slot")]
                public Types.TimeSlot? PickupTimeSlot { get; set; }

                /// <summary>
                /// 获取或设置寄件人地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender_address")]
                [System.Text.Json.Serialization.JsonPropertyName("sender_address")]
                public Types.Address? SenderAddress { get; set; }

                /// <summary>
                /// 获取或设置收件人地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recipient_address")]
                [System.Text.Json.Serialization.JsonPropertyName("recipient_address")]
                public Types.Address? RecipientAddress { get; set; }
            }
        }
    }
}
