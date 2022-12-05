namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateGetV1Response : DouyinOpenResponse<GoodLifeFulfilmentCertificateGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Certificate
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置券原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                                public int OriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置用户实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_ticket_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket_amount")]
                                public int MerchantTicketAmount { get; set; }
                            }

                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置团购名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置团购类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("groupon_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("groupon_type")]
                                public int GrouponType { get; set; }

                                /// <summary>
                                /// 获取或设置团购市场价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("market_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                                public int MarketPrice { get; set; }

                                /// <summary>
                                /// 获取或设置售卖开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sold_start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("sold_start_time")]
                                public long StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置商家 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                public string? AccountId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 外部 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("third_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("third_sku_id")]
                                public string? OutSKUId { get; set; }
                            }

                            public class VerifyResult
                            {
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
                                /// 获取或设置核销类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("verify_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("verify_type")]
                                public int VerifyType { get; set; }

                                /// <summary>
                                /// 获取或设置核销时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("verify_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                                public long VerifyTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置是否可撤销。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("can_cancel")]
                                [System.Text.Json.Serialization.JsonPropertyName("can_cancel")]
                                public bool CanCancel { get; set; }

                                /// <summary>
                                /// 获取或设置核销人抖音号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("verifier_unique_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("verifier_unique_id")]
                                public string? VerifierUniqueId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置加密券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypted_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                        public string EncryptedCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

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
                        /// 获取或设置过期时间时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expire_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                        public long ExpireTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? Code { get; set; }

                        /// <summary>
                        /// 获取或设置核销信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify")]
                        public Types.VerifyResult? VerifyResult { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置团购券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                public Types.Certificate Certificate { get; set; } = default!;
            }
        }
    }
}
