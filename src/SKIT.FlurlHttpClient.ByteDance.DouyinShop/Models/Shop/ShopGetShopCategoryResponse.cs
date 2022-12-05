namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/getShopCategory 接口的响应。</para>
    /// </summary>
    public class ShopGetShopCategoryResponse : DouyinShopResponse<ShopGetShopCategoryResponse.Types.Category[]>
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int CategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置类目级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("level")]
                [System.Text.Json.Serialization.JsonPropertyName("level")]
                public int Level { get; set; }

                /// <summary>
                /// 获取或设置父类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                public int? ParentCategoryId { get; set; }

                /// <summary>
                /// 获取或设置是否是叶子节点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_leaf")]
                [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                public bool IsLeaf { get; set; }

                /// <summary>
                /// 获取或设置是否有效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enable")]
                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                public bool IsEnabled { get; set; }
            }
        }
    }
}
