namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_categories/recommend 接口的响应。</para>
    /// </summary>
    public class ProductRecommendGlobalCategoriesResponse : TikTokShopResponse<ProductRecommendGlobalCategoriesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Category : ProductRecommendCategoriesResponse.Types.Data.Types.Category
                    {
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
            }
        }
    }
}
