namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/query_by_order 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerQueryByOrderV1Response : DouyinOpenResponse<GoodLifeSettleLedgerQueryByOrderV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class LedgerRecord : GoodLifeSettleLedgerDetailedQueryByOrderV1Response.Types.Data.Types.__zz__LedgerRecord
                    {
                        public static class Types
                        {
                            public class Amount : GoodLifeSettleLedgerDetailedQueryByOrderV1Response.Types.Data.Types.LedgerRecord.Types.Amount
                            {
                            }

                            public class SKU : GoodLifeSettleLedgerDetailedQueryByOrderV1Response.Types.Data.Types.LedgerRecord.Types.SKU
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
