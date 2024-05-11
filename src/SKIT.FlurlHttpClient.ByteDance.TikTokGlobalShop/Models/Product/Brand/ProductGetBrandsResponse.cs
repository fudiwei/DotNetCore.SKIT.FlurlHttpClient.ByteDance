namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/brands 接口的响应。</para>
    /// </summary>
    public class ProductGetBrandsResponse : TikTokShopResponse<ProductGetBrandsResponse.Types.Data>
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
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string BrandId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorized_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorized_status")]
                        public string AuthorizedStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_status")]
                        public string BrandStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是 T1 品牌。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_t1_brand")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_t1_brand")]
                        public bool IsT1Brand { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置品牌列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brands")]
                [System.Text.Json.Serialization.JsonPropertyName("brands")]
                public Types.Brand[] BrandList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
