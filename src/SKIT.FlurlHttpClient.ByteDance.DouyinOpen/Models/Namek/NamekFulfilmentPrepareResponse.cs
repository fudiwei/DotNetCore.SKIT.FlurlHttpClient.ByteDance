namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /namek/fulfilment/prepare 接口的响应。</para>
    /// </summary>
    public class NamekFulfilmentPrepareResponse : DouyinOpenResponse<NamekFulfilmentPrepareResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Certificate
                    {
                        public static class Types
                        {
                            public class Amount : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.Certificate.Types.Amount
                            {
                            }

                            public class SKU : GoodLifeFulfilmentCertificateGetV1Response.Types.Data.Types.Certificate.Types.SKU
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置加密券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypted_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                        public string EncryptedCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置团购 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU SKU { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置过期时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                        public long ExpireTimeUnixMilliseconds { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置一次验券的标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("verify_token")]
                [System.Text.Json.Serialization.JsonPropertyName("verify_token")]
                public string VerifyToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置团购券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificates")]
                [System.Text.Json.Serialization.JsonPropertyName("certificates")]
                public Types.Certificate[] CertificateList { get; set; } = default!;
            }
        }
    }
}
