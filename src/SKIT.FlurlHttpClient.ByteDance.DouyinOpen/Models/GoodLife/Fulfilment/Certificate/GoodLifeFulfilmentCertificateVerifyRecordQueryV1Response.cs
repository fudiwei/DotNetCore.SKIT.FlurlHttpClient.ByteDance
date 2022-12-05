namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/fulfilment/certificate/verify_record/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeFulfilmentCertificateVerifyRecordQueryV1Response : DouyinOpenResponse<GoodLifeFulfilmentCertificateVerifyRecordQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class VerifyRecord
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
                        /// 获取或设置分页游标。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cursor")]
                        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                        public string PageCursor { get; set; } = default!;

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
                        /// 获取或设置加密券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("encrypted_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
                        public string EncryptedCode { get; set; } = default!;

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
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置取消时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                        public long? CancelTimestamp { get; set; }

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
                    }
                }

                /// <summary>
                /// 获取或设置核销记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("records")]
                [System.Text.Json.Serialization.JsonPropertyName("records")]
                public Types.VerifyRecord[] VerifyRecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
