namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/listBrand 接口的响应。</para>
    /// </summary>
    public class BTASListBrandResponse : TikTokShopResponse<BTASListBrandResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Brand
                    {
                        public static class Types
                        {
                            public class Category
                            {
                                /// <summary>
                                /// 获取或设置支持类型 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public int Id { get; set; }

                                /// <summary>
                                /// 获取或设置支持类型名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                        public int BrandId { get; set; }

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                        public string BrandName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌支持类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_category_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_category_list")]
                        public Types.Category[] CategoryList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_list")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_list")]
                public Types.Brand[] BrandList { get; set; } = default!;
            }
        }
    }
}
