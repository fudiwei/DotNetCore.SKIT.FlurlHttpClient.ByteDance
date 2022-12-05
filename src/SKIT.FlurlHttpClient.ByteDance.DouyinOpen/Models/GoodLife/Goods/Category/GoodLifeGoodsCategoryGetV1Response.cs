namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/category/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsCategoryGetV1Response : DouyinOpenResponse<GoodLifeGoodsCategoryGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置上级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ParentCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类目层级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level")]
                        [System.Text.Json.Serialization.JsonPropertyName("level")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Level { get; set; }

                        /// <summary>
                        /// 获取或设置是否是叶子节点。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_leaf")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                        public bool IsLeaf { get; set; }

                        /// <summary>
                        /// 获取或设置是否开放。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("enable")]
                        [System.Text.Json.Serialization.JsonPropertyName("enable")]
                        public bool IsEnabled { get; set; }
                    }

                    public class CategoryTreeItem : Category
                    {
                        /// <summary>
                        /// 获取或设置子类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_tree_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_tree_infos")]
                        public Types.Category[]? SubCategoryList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("category_infos")]
                public Types.Category[]? CategoryList { get; set; }

                /// <summary>
                /// 获取或设置类目树形列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_tree_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("category_tree_infos")]
                public Types.CategoryTreeItem[]? CategoryTreeItems { get; set; }
            }
        }
    }
}
