namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories/{category_id}/global_rules 接口的响应。</para>
    /// </summary>
    public class ProductGetGlobalCategoryRulesResponse : TikTokShopResponse<ProductGetGlobalCategoryRulesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductCertification : ProductGetCategoryRulesResponse.Types.Data.Types.Certification
                    {
                        /// <summary>
                        /// 获取或设置必填的地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("required_regions")]
                        [System.Text.Json.Serialization.JsonPropertyName("required_regions")]
                        public string[] RequiredRegionCodeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置选填的地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("optional_regions")]
                        [System.Text.Json.Serialization.JsonPropertyName("optional_regions")]
                        public string[] OptionalRegionCodeList { get; set; } = default!;
                    }

                    public class SizeChart : ProductGetCategoryRulesResponse.Types.Data.Types.SizeChart
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商品认证列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_certifications")]
                [System.Text.Json.Serialization.JsonPropertyName("product_certifications")]
                public Types.ProductCertification[] ProductCertificationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置尺码表信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size_chart")]
                [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
                public Types.SizeChart? SizeChart { get; set; }
            }
        }
    }
}
