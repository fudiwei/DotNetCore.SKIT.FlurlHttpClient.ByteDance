namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /authorization/{version}/category_assets 接口的响应。</para>
    /// </summary>
    public class AuthorizationGetCategoryAssetsResponse : TikTokShopResponse<AuthorizationGetCategoryAssetsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CategoryAsset
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
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int CategoryId { get; set; }

                                /// <summary>
                                /// 获取或设置类目名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺密码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cipher")]
                        [System.Text.Json.Serialization.JsonPropertyName("cipher")]
                        public string Cipher { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置目标市场。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("target_market")]
                        [System.Text.Json.Serialization.JsonPropertyName("target_market")]
                        public string TargetMarket { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类目信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category")]
                        [System.Text.Json.Serialization.JsonPropertyName("category")]
                        public Types.Category Category { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置类目资产列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_assets")]
                [System.Text.Json.Serialization.JsonPropertyName("category_assets")]
                public Types.CategoryAsset[] CategoryAssetList { get; set; } = default!;
            }
        }
    }
}
