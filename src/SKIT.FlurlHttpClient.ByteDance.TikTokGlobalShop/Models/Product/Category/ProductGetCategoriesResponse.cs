namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories 接口的响应。</para>
    /// </summary>
    public class ProductGetCategoriesResponse : TikTokShopResponse<ProductGetCategoriesResponse.Types.Data>
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
                        /// 获取或设置上级分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ParentCategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是子分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_leaf")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                        public bool IsLeaf { get; set; }

                        /// <summary>
                        /// 获取或设置权限状态列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("permission_statuses")]
                        [System.Text.Json.Serialization.JsonPropertyName("permission_statuses")]
                        public string[] PermissionStatusList { get; set; } = default!;
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
