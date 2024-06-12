namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/products/seo_words 接口的响应。</para>
    /// </summary>
    public class ProductGetProductSEOWordsResponse : TikTokShopResponse<ProductGetProductSEOWordsResponse.Types.Data>
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
                            public class SEOWord
                            {
                                /// <summary>
                                /// 获取或设置关键词。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string Text { get; set; } = default!;
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
                        /// 获取或设置 SEO 关键词列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seo_words")]
                        [System.Text.Json.Serialization.JsonPropertyName("seo_words")]
                        public Types.SEOWord[] SEOWordList { get; set; } = default!;
                    }
                }

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
