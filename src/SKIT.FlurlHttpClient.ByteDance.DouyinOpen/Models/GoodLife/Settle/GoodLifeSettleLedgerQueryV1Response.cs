namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerQueryV1Response : DouyinOpenResponse<GoodLifeSettleLedgerQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class LedgerRecord : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.__zz__LedgerRecord
                    {
                        public static class Types
                        {
                            public class Amount : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.LedgerRecord.Types.Amount
                            {
                            }

                            public class Certificate : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.LedgerRecord.Types.Certificate
                            {
                            }

                            public class SKU : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.LedgerRecord.Types.SKU
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置券信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                        public Types.Certificate? Certificate { get; set; }

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
                /// 获取或设置分账记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_records")]
                public List<Types.LedgerRecord>? LedgerRecordList { get; set; }

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public string? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
