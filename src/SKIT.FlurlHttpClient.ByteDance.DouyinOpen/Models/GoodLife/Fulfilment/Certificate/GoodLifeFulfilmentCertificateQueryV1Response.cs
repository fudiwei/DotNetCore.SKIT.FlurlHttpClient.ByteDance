namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateQueryV1Response : DouyinOpenResponse<GoodLifeFulfilmentCertificateQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Certificate : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.__zz__Certificate
                    {
                        public static class Types
                        {
                            public class Amount : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.Certificate.Types.Amount
                            {
                            }

                            public class SKU : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.Certificate.Types.SKU
                            {
                            }

                            public class VerifyResult : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.Certificate.Types.VerifyResult
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount? Amount { get; set; }

                        /// <summary>
                        /// 获取或设置团购 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU? SKU { get; set; }

                        /// <summary>
                        /// 获取或设置核销信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify")]
                        public Types.VerifyResult? VerifyResult { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置团购券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public List<Types.Certificate>? CertificateList { get; set; }
            }
        }
    }
}
