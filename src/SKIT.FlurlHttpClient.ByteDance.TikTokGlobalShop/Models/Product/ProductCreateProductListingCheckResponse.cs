namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/listing_check 接口的响应。</para>
    /// </summary>
    public class ProductCreateProductListingCheckResponse : TikTokShopResponse<ProductCreateProductListingCheckResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailReason
                    {
                        /// <summary>
                        /// 获取或设置失败原因编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public int Code { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string Message { get; set; } = default!;
                    }

                    public class Warning : ProductCreateProductResponse.Types.Data.Types.Warning
                    {
                    }

                    public class Diagnosis
                    {
                        public static class Types
                        {
                            public class DiagnosisResult : ProductGetProductDiagnosesResponse.Types.Data.Types.Product.Types.Diagnosis.Types.DiagnosisResult
                            {
                            }

                            public class Suggestion : ProductGetProductDiagnosesResponse.Types.Data.Types.Product.Types.Diagnosis.Types.Suggestion
                            {
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
                        [Newtonsoft.Json.JsonProperty("suggestions")]
                        [System.Text.Json.Serialization.JsonPropertyName("suggestions")]
                        public Types.Suggestion? Suggestion { get; set; }
                    }

                    public class ListingQuality : ProductGetProductDiagnosesResponse.Types.Data.Types.Product.Types.ListingQuality
                    {
                    }
                }

                /// <summary>
                /// 获取或设置检查结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_result")]
                [System.Text.Json.Serialization.JsonPropertyName("check_result")]
                public string CheckResult { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reasons")]
                public Types.FailReason[]? FailReasonList { get; set; } = default!;

                /// <summary>
                /// 获取或设置警告信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warnings")]
                [System.Text.Json.Serialization.JsonPropertyName("warnings")]
                public Types.Warning? Warning { get; set; }

                /// <summary>
                /// 获取或设置诊断列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("diagnoses")]
                [System.Text.Json.Serialization.JsonPropertyName("diagnoses")]
                public Types.Diagnosis[]? DiagnosisList { get; set; }

                /// <summary>
                /// 获取或设置上架质量信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("listing_quality")]
                [System.Text.Json.Serialization.JsonPropertyName("listing_quality")]
                public Types.ListingQuality? ListingQuality { get; set; }
            }
        }
    }
}
