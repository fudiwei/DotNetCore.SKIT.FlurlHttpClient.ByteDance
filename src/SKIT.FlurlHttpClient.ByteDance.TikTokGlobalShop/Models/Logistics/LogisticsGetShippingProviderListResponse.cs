namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/shipping_providers 接口的响应。</para>
    /// </summary>
    public class LogisticsGetShippingProviderListResponse : TikTokShopResponse<LogisticsGetShippingProviderListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DeliveryOption
                    {
                        public static class Types
                        {
                            public class ItemWeightLimit
                            {
                                /// <summary>
                                /// 获取或设置最小重量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("min_weight")]
                                [System.Text.Json.Serialization.JsonPropertyName("min_weight")]
                                public int MinWeight { get; set; }

                                /// <summary>
                                /// 获取或设置最大重量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("max_weight")]
                                [System.Text.Json.Serialization.JsonPropertyName("max_weight")]
                                public int MaxWeight { get; set; }
                            }

                            public class ItemDimensionLimit
                            {
                                /// <summary>
                                /// 获取或设置长度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("length")]
                                [System.Text.Json.Serialization.JsonPropertyName("length")]
                                public int Length { get; set; }

                                /// <summary>
                                /// 获取或设置宽度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("width")]
                                [System.Text.Json.Serialization.JsonPropertyName("width")]
                                public int Width { get; set; }

                                /// <summary>
                                /// 获取或设置高度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("height")]
                                [System.Text.Json.Serialization.JsonPropertyName("height")]
                                public int Height { get; set; }
                            }

                            public class ShippingProvider
                            {
                                /// <summary>
                                /// 获取或设置运输服务商 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                                public string ShippingProviderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置运输服务商名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_provider_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_name")]
                                public string ShippingProviderName { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置配送方式 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string DeliveryOptionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_name")]
                        public string DeliveryOptionName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置货品重量限制信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_weight_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_weight_limit")]
                        public Types.ItemWeightLimit ItemWeightLimit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置货品尺寸限制信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_dimension_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_dimension_limit")]
                        public Types.ItemDimensionLimit ItemDimensionLimit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置运输服务商列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_list")]
                        public Types.ShippingProvider[] ShippingProviderList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置配送方式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_option_list")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_option_list")]
                public Types.DeliveryOption[] DeliveryOptionList { get; set; } = default!;
            }
        }
    }
}
