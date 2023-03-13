namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/categories 接口的响应。</para>
    /// </summary>
    public class ProductGetCategoryListResponse : TikTokShopResponse<ProductGetCategoryListResponse.Types.Data>
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
                        public string CategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置上级分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        public string ParentCategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置本地显示名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_display_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_display_name")]
                        public string LocalDisplayName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是子分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_leaf")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                        public bool IsLeaf { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_list")]
                [System.Text.Json.Serialization.JsonPropertyName("category_list")]
                public Types.Category[] CategoryList { get; set; } = default!;
            }
        }
    }
}
