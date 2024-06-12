namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/products/suggestions 接口的响应。</para>
    /// </summary>
    public class ProductGetProductSuggestionsResponse : TikTokShopResponse<ProductGetProductSuggestionsResponse.Types.Data>
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
                            public class Suggestion
                            {
                                public static class Types
                                {
                                    public class Item
                                    {
                                        /// <summary>
                                        /// 获取或设置文本。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public string Text { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置字段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("field")]
                                [System.Text.Json.Serialization.JsonPropertyName("field")]
                                public string Field { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置建议项。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("items")]
                                [System.Text.Json.Serialization.JsonPropertyName("items")]
                                public Types.Item[] Items { get; set; } = default!;
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
                        /// 获取或设置修改建议列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("suggestions")]
                        [System.Text.Json.Serialization.JsonPropertyName("suggestions")]
                        public Types.Suggestion[] SuggestionList { get; set; } = default!;
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
