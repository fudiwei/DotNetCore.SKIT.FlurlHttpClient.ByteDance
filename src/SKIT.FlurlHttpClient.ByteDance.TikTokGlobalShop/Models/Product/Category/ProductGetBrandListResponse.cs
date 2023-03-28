namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/brands 接口的响应。</para>
    /// </summary>
    public class ProductGetBrandListResponse : TikTokShopResponse<ProductGetBrandListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string BrandId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string BrandName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorized_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorized_status")]
                        public int AuthorizedStatus { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_list")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_list")]
                public Types.Brand[] BrandList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_num")]
                public int TotalCount { get; set; }
            }
        }
    }
}
