using System.Collections.Generic;

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
                    public class LedgerRecord : GoodLifeSettleLedgerDetailedQueryByOrderV1Response.Types.Data.Types.LedgerRecord
                    {
                    }
                }

                /// <summary>
                /// 获取或设置分账记录字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_records")]
                public IDictionary<string, Types.LedgerRecord> LedgerRecordMap { get; set; } = default!;

                /// <summary>
                /// 获取或设置二次分账记录字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_second_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_second_records")]
                public IDictionary<string, Types.LedgerRecord> SecondLedgerRecordMap { get; set; } = default!;
            }
        }
    }
}
