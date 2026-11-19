namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/tts/product/ 接口的响应。</para>
    /// </summary>
    public class ResearchTTSProductResponse : TikTokV2Response<ResearchTTSProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                        public string? ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string? ProductName { get; set; }

                        /// <summary>
                        /// 获取或设置商品描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_description")]
                        public string? ProductDescription { get; set; }

                        /// <summary>
                        /// 获取或设置商品价格列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_price")]
                        public List<string>? ProductPriceList { get; set; }

                        /// <summary>
                        /// 获取或设置商品售出数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_sold_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_sold_count")]
                        public long ProductSoldCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品评论数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_review_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_review_count")]
                        public long ProductReviewCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品一星评价数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_rating_1_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_rating_1_count")]
                        public long ProductRating1Count { get; set; }

                        /// <summary>
                        /// 获取或设置商品二星评价数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_rating_2_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_rating_2_count")]
                        public long ProductRating2Count { get; set; }

                        /// <summary>
                        /// 获取或设置商品三星评价数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_rating_3_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_rating_3_count")]
                        public long ProductRating3Count { get; set; }

                        /// <summary>
                        /// 获取或设置商品四星评价数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_rating_4_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_rating_4_count")]
                        public long ProductRating4Count { get; set; }

                        /// <summary>
                        /// 获取或设置商品五星评价数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_rating_5_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_rating_5_count")]
                        public long ProductRating5Count { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_data")]
                [System.Text.Json.Serialization.JsonPropertyName("product_data")]
                public List<Types.Product>? ProductList { get; set; }
            }
        }
    }
}
