namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/shipping_service/get 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetShippingServiceResponse : TikTokShopResponse<FulfillmentGetShippingServiceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Dimension
                    {
                        /// <summary>
                        /// 获取或设置长度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("length")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("length")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? Length { get; set; }

                        /// <summary>
                        /// 获取或设置宽度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? Width { get; set; }

                        /// <summary>
                        /// 获取或设置高度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? Height { get; set; }
                    }

                    public class ShippingServiceInfo
                    {
                        /// <summary>
                        /// 获取或设置服务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ServiceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string ServiceName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal Price { get; set; }

                        /// <summary>
                        /// 获取或设置价格币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置预计最早运输时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_time_start")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_time_start")]
                        public int DeliveryTimestampStart { get; set; }

                        /// <summary>
                        /// 获取或设置预计最晚运输时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_time_end")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_time_end")]
                        public int DeliveryTimestampEnd { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provider_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("provider_id")]
                        public string? ProviderId { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商名称
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("provider_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("provider_name")]
                        public string? ProviderName { get; set; }

                        /// <summary>
                        /// 获取或设置是否默认。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_default")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                        public bool? IsDefault { get; set; }
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
                /// 获取或设置重量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal? Weight { get; set; }

                /// <summary>
                /// 获取或设置重量单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight_unit")]
                [System.Text.Json.Serialization.JsonPropertyName("weight_unit")]
                public int? WeightUnit { get; set; }

                /// <summary>
                /// 获取或设置尺寸信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dimension")]
                [System.Text.Json.Serialization.JsonPropertyName("dimension")]
                public Types.Dimension? Dimension { get; set; }

                /// <summary>
                /// 获取或设置尺寸单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("dimension_unit")]
                [System.Text.Json.Serialization.JsonPropertyName("dimension_unit")]
                public int? DimensionUnit { get; set; }

                /// <summary>
                /// 获取或设置货运服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_service_info")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_service_info")]
                public Types.ShippingServiceInfo[] ShippingServiceList { get; set; } = default!;
            }
        }
    }
}
