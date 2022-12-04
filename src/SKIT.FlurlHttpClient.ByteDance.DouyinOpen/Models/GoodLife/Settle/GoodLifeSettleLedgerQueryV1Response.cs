namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerQueryV1Response : DouyinOpenResponse<GoodLifeSettleLedgerQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class LedgerRecord : GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data.Types.LedgerRecord
                    {
                    }
                }

                /// <summary>
                /// 获取或设置分账记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_records")]
                public Types.LedgerRecord[] LedgerRecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public string? PageCursor { get; set; }

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
