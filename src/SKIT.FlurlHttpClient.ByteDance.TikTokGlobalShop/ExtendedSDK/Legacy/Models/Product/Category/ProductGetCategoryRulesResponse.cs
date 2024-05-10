namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/categories/rules 接口的响应。</para>
    /// </summary>
    public class ProductGetCategoryRulesResponse : TikTokShopLegacyResponse<ProductGetCategoryRulesResponse.Types.Data>
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
                            public class ProductCertification
                            {
                                /// <summary>
                                /// 获取或设置商品认证 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string CertificationId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品认证名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string CertificationName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置示例。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sample")]
                                [System.Text.Json.Serialization.JsonPropertyName("sample")]
                                public string? Sample { get; set; }

                                /// <summary>
                                /// 获取或设置是否必填。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_mandatory")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_mandatory")]
                                public bool IsMandatory { get; set; }
                            }

                            public class ExemptionOfIdentifierCode
                            {
                                /// <summary>
                                /// 获取或设置是否支持 GTIN 豁免。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("support_identifier_code_exemption")]
                                [System.Text.Json.Serialization.JsonPropertyName("support_identifier_code_exemption")]
                                public bool IsSupportIdentifierCodeExemption { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置是否支持输入尺码表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("support_size_chart")]
                        [System.Text.Json.Serialization.JsonPropertyName("support_size_chart")]
                        public bool IsSupportSizeChart { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持货到付款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("support_cod")]
                        [System.Text.Json.Serialization.JsonPropertyName("support_cod")]
                        public bool IsSupportCashOnDelivery { get; set; }

                        /// <summary>
                        /// 获取或设置是否必填尺码表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_size_chart_mandatory")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_size_chart_mandatory")]
                        public bool IsSizeChartMandatory { get; set; }

                        /// <summary>
                        /// 获取或设置产品标识码豁免信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exemption_of_identifier_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("exemption_of_identifier_code")]
                        public Types.ExemptionOfIdentifierCode? ExemptionOfIdentifierCode { get; set; }

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
