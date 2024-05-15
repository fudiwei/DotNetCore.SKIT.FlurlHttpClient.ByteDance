namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages 接口的响应。</para>
    /// </summary>
    public class FulfillmentCreatePackageResponse : TikTokShopResponse<FulfillmentCreatePackageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class PackageDimension : FulfillmentGetPackageDetailResponse.Types.Data.Types.PackageDimension
                    {
                    }

                    public class PackageWeight : FulfillmentGetPackageDetailResponse.Types.Data.Types.PackageWeight
                    {
                    }

                    public class ShippingService
                    {
                        /// <summary>
                        /// 获取或设置运输服务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ShippingServiceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置运输服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Price { get; set; }

                        /// <summary>
                        /// 获取或设置最小运输天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("earliest_delivery_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("earliest_delivery_days")]
                        public int EarliestDeliveryDays { get; set; }

                        /// <summary>
                        /// 获取或设置最大运输天数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latest_delivery_days")]
                        [System.Text.Json.Serialization.JsonPropertyName("latest_delivery_days")]
                        public int LatestDeliveryDays { get; set; }

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
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置运输服务信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_service_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_service_info")]
                public Types.ShippingService? ShippingService { get; set; }

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
            }
        }
    }
}
