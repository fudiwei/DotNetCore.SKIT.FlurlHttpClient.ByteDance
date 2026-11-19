namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/tts/shop/ 接口的响应。</para>
    /// </summary>
    public class ResearchTTSShopResponse : TikTokV2Response<ResearchTTSShopResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Shop
                    {
                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                        public string? ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                        public string? ShopName { get; set; }

                        /// <summary>
                        /// 获取或设置店铺评分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_rating")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_rating")]
                        public string? ShopRating { get; set; }

                        /// <summary>
                        /// 获取或设置店铺评价数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_review_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_review_count")]
                        public long ShopReviewCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品售出数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_sold_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_sold_count")]
                        public long ItemSoldCount { get; set; }

                        /// <summary>
                        /// 获取或设置店铺表现值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_performance_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_performance_value")]
                        public int ShopPerformanceValue { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置店铺列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_data")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_data")]
                public List<Types.Shop>? ShopList { get; set; }
            }
        }
    }
}
