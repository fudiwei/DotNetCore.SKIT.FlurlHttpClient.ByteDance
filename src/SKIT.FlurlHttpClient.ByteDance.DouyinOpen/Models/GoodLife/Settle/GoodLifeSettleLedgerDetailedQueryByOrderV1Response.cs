namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/detailed_query_by_order 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerDetailedQueryByOrderV1Response : DouyinOpenResponse<GoodLifeSettleLedgerDetailedQueryByOrderV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public abstract class __zz__LedgerRecord
                    {
                        /// <summary>
                        /// 获取或设置分账记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ledger_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ledger_id")]
                        public string? LedgerId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string? OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string? CertificateId { get; set; }

                        /// <summary>
                        /// 获取或设置券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string? CertificateCode { get; set; }

                        /// <summary>
                        /// 获取或设置核销记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
                        public string? VerifyId { get; set; }

                        /// <summary>
                        /// 获取或设置核销时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                        public long VerifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置分账状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }

                    public class LedgerRecord : __zz__LedgerRecord
                    {
                        public static class Types
                        {
                            public class Amount : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.LedgerRecord.Types.Amount
                            {
                            }

                            public class SKU : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.LedgerRecord.Types.SKU
                            {
                                /// <summary>
                                /// 获取或设置团购名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public new string? Title
                                {
                                    get { return base.Title; }
                                    set { base.Title = value; }
                                }
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
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        public Types.SKU? SKU { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分账记录字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_records")]
                public Dictionary<string, Types.LedgerRecord>? LedgerRecordMap { get; set; }

                /// <summary>
                /// 获取或设置二次分账记录字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_second_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_second_records")]
                public Dictionary<string, Types.LedgerRecord>? SecondLedgerRecordMap { get; set; }
            }
        }
    }
}
