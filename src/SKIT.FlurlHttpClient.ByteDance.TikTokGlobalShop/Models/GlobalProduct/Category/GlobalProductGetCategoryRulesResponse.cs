namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/global_products/categories/rules 接口的响应。</para>
    /// </summary>
    public class GlobalProductGetCategoryRulesResponse : TikTokShopResponse<GlobalProductGetCategoryRulesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CategoryRule
                    {
                        public static class Types
                        {
                            public class ProductCertification : ProductGetCategoryRulesResponse.Types.Data.Types.CategoryRule.Types.ProductCertification
                            {
                                /// <summary>
                                /// 获取或设置必填地区列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mandatory_regions")]
                                [System.Text.Json.Serialization.JsonPropertyName("mandatory_regions")]
                                public string[]? MandatoryRegionList { get; set; }

                                /// <summary>
                                /// 获取或设置选填地区列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("optional_regions")]
                                [System.Text.Json.Serialization.JsonPropertyName("optional_regions")]
                                public string[]? OptionalRegionList { get; set; }
                            }

                            public class SizeChartRule
                            {
                                /// <summary>
                                /// 获取或设置是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_size_chart_mandatory")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_size_chart_mandatory")]
                                public bool IsMandatory { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否支持输入尺码表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("support_size_chart")]
                        [System.Text.Json.Serialization.JsonPropertyName("support_size_chart")]
                        public bool IsSupportSizeChart { get; set; }

                        /// <summary>
                        /// 获取或设置尺码表规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("size_chart_rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("size_chart_rule")]
                        public Types.SizeChartRule? SizeChartRule { get; set; }

                        /// <summary>
                        /// 获取或设置商品认证列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_certifications")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_certifications")]
                        public Types.ProductCertification[] ProductCertificationList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置分类规则列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_rules")]
                [System.Text.Json.Serialization.JsonPropertyName("category_rules")]
                public Types.CategoryRule[] CategoryRuleList { get; set; } = default!;
            }
        }
    }
}
