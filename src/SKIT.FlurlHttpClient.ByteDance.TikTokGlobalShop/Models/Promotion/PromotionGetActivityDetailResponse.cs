namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /promotion/{version}/activities/{activity_id} 接口的响应。</para>
    /// </summary>
    public class PromotionGetActivityDetailResponse : TikTokShopResponse<PromotionGetActivityDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : PromotionSearchActivitiesResponse.Types.Data.Types.Activity
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class Price
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置价格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public decimal Amount { get; set; }
                            }

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
                                /// 获取或设置数量限制。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity_limit")]
                                public int QuantityLimit { get; set; }

                                /// <summary>
                                /// 获取或设置单个用户数量限制。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity_per_user")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity_per_user")]
                                public int QuantityPerUser { get; set; }

                                /// <summary>
                                /// 获取或设置活动折扣（单位：百分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                                public int? Discount { get; set; }

                                /// <summary>
                                /// 获取或设置活动价信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("activity_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("activity_price")]
                                public Types.Price? Price { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置数量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity_limit")]
                        public int QuantityLimit { get; set; }

                        /// <summary>
                        /// 获取或设置单个用户数量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity_per_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity_per_user")]
                        public int QuantityPerUser { get; set; }

                        /// <summary>
                        /// 获取或设置活动折扣（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public int? Discount { get; set; }

                        /// <summary>
                        /// 获取或设置活动价信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_price")]
                        public Types.Price? Price { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public override string ActivityId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }
    }
}
