namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /promotion/activity/get 接口的响应。</para>
    /// </summary>
    public class PromotionGetActivityDetailResponse : TikTokShopResponse<PromotionGetActivityDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置促销价格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promotion_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("promotion_price")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal? PromotionPrice { get; set; }

                                /// <summary>
                                /// 获取或设置折扣比例（单位：百分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                                public decimal? Discount { get; set; }

                                /// <summary>
                                /// 获取或设置库存上限。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("num_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("num_limit")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int StockLimit { get; set; }

                                /// <summary>
                                /// 获取或设置用户使用上限。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_limit")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int UserLimit { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置促销价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualNullableDecimalReadOnlyConverter))]
                        public decimal? PromotionPrice { get; set; }

                        /// <summary>
                        /// 获取或设置折扣比例（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualNullableDecimalReadOnlyConverter))]
                        public decimal? Discount { get; set; }

                        /// <summary>
                        /// 获取或设置库存上限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("num_limit")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int StockLimit { get; set; }

                        /// <summary>
                        /// 获取或设置用户使用上限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_limit")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int UserLimit { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
                        public Types.SKU[]? SKUList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置促销 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_id")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string PromotionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置促销类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_type")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_type")]
                public int PromotionType { get; set; }

                /// <summary>
                /// 获取或设置活动标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int ProductType { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_list")]
                public Types.Product[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置活动状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置活动开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置活动结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("updatcreate_timee_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }
    }
}
