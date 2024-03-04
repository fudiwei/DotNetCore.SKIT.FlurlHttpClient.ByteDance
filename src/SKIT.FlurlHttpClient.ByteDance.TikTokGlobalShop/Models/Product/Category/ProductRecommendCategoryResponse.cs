namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/category_recommend 接口的响应。</para>
    /// </summary>
    public class ProductRecommendCategoryResponse : TikTokShopResponse<ProductRecommendCategoryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分类名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string CategoryName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分类层级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level")]
                        [System.Text.Json.Serialization.JsonPropertyName("level")]
                        public int Level { get; set; }

                        /// <summary>
                        /// 获取或设置是否是子分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_leaf")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                        public bool IsLeaf { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置推荐分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categories")]
                [System.Text.Json.Serialization.JsonPropertyName("categories")]
                public Types.Category[] CategoryList { get; set; } = default!;

                /// <summary>
                /// 获取或设置推荐子分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leaf_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("leaf_category_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string LeafCategoryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置优先级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("priority")]
                [System.Text.Json.Serialization.JsonPropertyName("priority")]
                public int Priority { get; set; }
            }
        }
    }
}
