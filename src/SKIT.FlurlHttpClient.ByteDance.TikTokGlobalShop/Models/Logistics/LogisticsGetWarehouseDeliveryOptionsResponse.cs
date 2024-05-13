namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/{version}/warehouses/{warehouse_id}/delivery_options 接口的响应。</para>
    /// </summary>
    public class LogisticsGetWarehouseDeliveryOptionsResponse : TikTokShopResponse<LogisticsGetWarehouseDeliveryOptionsResponse.Types.Data>
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
                            public class DimensionLimit
                            {
                                /// <summary>
                                /// 获取或设置最大长度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("max_length")]
                                [System.Text.Json.Serialization.JsonPropertyName("max_length")]
                                public int MaxLength { get; set; }

                                /// <summary>
                                /// 获取或设置最大宽度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("max_width")]
                                [System.Text.Json.Serialization.JsonPropertyName("max_width")]
                                public int MaxWidth { get; set; }

                                /// <summary>
                                /// 获取或设置最大高度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("max_height")]
                                [System.Text.Json.Serialization.JsonPropertyName("max_height")]
                                public int MaxHeight { get; set; }

                                /// <summary>
                                /// 获取或设置尺寸单位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                public string Unit { get; set; } = default!;
                            }

                            public class WeightLimit
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

                                /// <summary>
                                /// 获取或设置重量单位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                public string Unit { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置配送方式 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string DeliveryOptionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置尺寸限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("dimension_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("dimension_limit")]
                        public Types.DimensionLimit DimensionLimit { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置重量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("weight_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("weight_limit")]
                        public Types.WeightLimit WeightLimit { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置配送方式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_options")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_options")]
                public Types.DeliveryOption[] DeliveryOptionList { get; set; } = default!;
            }
        }
    }
}
