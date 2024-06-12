namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/products/diagnoses 接口的响应。</para>
    /// </summary>
    public class ProductGetProductDiagnosesResponse : TikTokShopResponse<ProductGetProductDiagnosesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class Diagnosis
                            {
                                public static class Types
                                {
                                    public class DiagnosisResult
                                    {
                                        /// <summary>
                                        /// 获取或设置问题代码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                                        public string Code { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置如何解决。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("how_to_solve")]
                                        [System.Text.Json.Serialization.JsonPropertyName("how_to_solve")]
                                        public string HowToSolve { get; set; } = default!;
                                    }

                                    public class Suggestion
                                    {
                                        public static class Types
                                        {
                                            public class SEOWord
                                            {
                                                /// <summary>
                                                /// 获取或设置关键词。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                public string Text { get; set; } = default!;
                                            }

                                            public class SmartText
                                            {
                                                /// <summary>
                                                /// 获取或设置智能文本。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                public string Text { get; set; } = default!;
                                            }

                                            public class Image
                                            {
                                                /// <summary>
                                                /// 获取或设置图片宽度（单位：像素）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("width")]
                                                [System.Text.Json.Serialization.JsonPropertyName("width")]
                                                public int Width { get; set; }

                                                /// <summary>
                                                /// 获取或设置图片高度（单位：像素）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("height")]
                                                [System.Text.Json.Serialization.JsonPropertyName("height")]
                                                public int Height { get; set; }

                                                /// <summary>
                                                /// 获取或设置原始图片 URI。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("uri")]
                                                [System.Text.Json.Serialization.JsonPropertyName("uri")]
                                                public string OriginalUri { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置原始图片 URL。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("url")]
                                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                                public string OriginalUrl { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置优化后图片 URI。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("optimized_uri")]
                                                [System.Text.Json.Serialization.JsonPropertyName("optimized_uri")]
                                                public string OptimizedUri { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置优化后图片 URL。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("optimized_url")]
                                                [System.Text.Json.Serialization.JsonPropertyName("optimized_url")]
                                                public string OptimizedUrl { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置 SEO 关键词列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("seo_words")]
                                        [System.Text.Json.Serialization.JsonPropertyName("seo_words")]
                                        public Types.SEOWord[]? SEOWordList { get; set; }

                                        /// <summary>
                                        /// 获取或设置智能文本列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("smart_texts")]
                                        [System.Text.Json.Serialization.JsonPropertyName("smart_texts")]
                                        public Types.SmartText[]? SmartTextList { get; set; }

                                        /// <summary>
                                        /// 获取或设置图片列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("images")]
                                        [System.Text.Json.Serialization.JsonPropertyName("images")]
                                        public Types.Image[]? ImageList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置字段。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("field")]
                                [System.Text.Json.Serialization.JsonPropertyName("field")]
                                public string Field { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置诊断结果列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("diagnosis_results")]
                                [System.Text.Json.Serialization.JsonPropertyName("diagnosis_results")]
                                public Types.DiagnosisResult[] DiagnosisResultList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置修改建议。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("suggestion")]
                                [System.Text.Json.Serialization.JsonPropertyName("suggestion")]
                                public Types.Suggestion? Suggestion { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置诊断列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("diagnoses")]
                        [System.Text.Json.Serialization.JsonPropertyName("diagnoses")]
                        public Types.Diagnosis[] DiagnosisList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }
    }
}
