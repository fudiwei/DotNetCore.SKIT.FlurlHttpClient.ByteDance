namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/fulfilment/certificate/verify 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateVerifyV1Response : TikTokResponse<GoodLifeFulfilmentCertificateVerifyV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class VerifyResult
                    {
                        /// <summary>
                        /// 获取或设置验券结果码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("result")]
                        [System.Text.Json.Serialization.JsonPropertyName("result")]
                        public int ResultCode { get; set; }

                        /// <summary>
                        /// 获取或设置验券结果说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg")]
                        public string? ResultMessage { get; set; }

                        /// <summary>
                        /// 获取或设置核销记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
                        public string VerifyId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                        public long VerifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string Code { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置原始券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_code")]
                        public string? OriginCode { get; set; }

                        /// <summary>
                        /// 获取或设置商家团购账号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                        public string? AccountId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置核销结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_results")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_results")]
                public Types.VerifyResult[] VerifyResultList { get; set; } = default!;
            }
        }
    }
}
