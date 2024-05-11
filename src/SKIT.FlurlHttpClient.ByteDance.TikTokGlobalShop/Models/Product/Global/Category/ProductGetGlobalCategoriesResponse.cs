namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/global_categories 接口的响应。</para>
    /// </summary>
    public class ProductGetGlobalCategoriesResponse : TikTokShopResponse<ProductGetGlobalCategoriesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Category : ProductGetCategoriesResponse.Types.Data.Types.Category
                    {
                    }
                }

                /// <summary>
                /// 获取或设置分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("categories")]
                [System.Text.Json.Serialization.JsonPropertyName("categories")]
                public Types.Category[] CategoryList { get; set; } = default!;
            }
        }
    }
}
