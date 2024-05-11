namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories/{category_id}/rules 接口的响应。</para>
    /// </summary>
    public class ProductGetCategoryRulesResponse : TikTokShopResponse<ProductGetCategoryRulesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Certification
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
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置示例图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sample_image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("sample_image_url")]
                        public string? SampleImageUrl { get; set; }

                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }
                    }

                    public class SizeChart
                    {
                        /// <summary>
                        /// 获取或设置是否支持。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_supported")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_supported")]
                        public bool IsSupported { get; set; }

                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }
                    }

                    public class CashOnDelivery
                    {
                        /// <summary>
                        /// 获取或设置是否支持。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_supported")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_supported")]
                        public bool IsSupported { get; set; }
                    }

                    public class PackageDimension
                    {
                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }
                    }

                    public class ExtendedProducerResponsibility
                    {
                        /// <summary>
                        /// 获取或设置是否必须。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_required")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_required")]
                        public bool IsRequired { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品认证列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_certifications")]
                [System.Text.Json.Serialization.JsonPropertyName("product_certifications")]
                public Types.Certification[] CertificationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置尺码表信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size_chart")]
                [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
                public Types.SizeChart? SizeChart { get; set; }

                /// <summary>
                /// 获取或设置货到付款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cod")]
                [System.Text.Json.Serialization.JsonPropertyName("cod")]
                public Types.CashOnDelivery? CashOnDelivery { get; set; }

                /// <summary>
                /// 获取或设置包装尺寸信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_dimension")]
                [System.Text.Json.Serialization.JsonPropertyName("package_dimension")]
                public Types.PackageDimension? PackageDimension { get; set; }

                /// <summary>
                /// 获取或设置 EPR 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("epr")]
                [System.Text.Json.Serialization.JsonPropertyName("epr")]
                public Types.ExtendedProducerResponsibility? ExtendedProducerResponsibility { get; set; }
            }
        }
    }
}
