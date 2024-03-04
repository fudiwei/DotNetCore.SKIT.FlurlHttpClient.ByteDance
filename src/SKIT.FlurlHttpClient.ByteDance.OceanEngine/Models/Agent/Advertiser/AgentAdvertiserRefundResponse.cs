namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/agent/advertiser/refund 接口的响应。</para>
    /// </summary>
    public class AgentAdvertiserRefundResponse : OceanEngineResponse<AgentAdvertiserRefundResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置交易流水号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_seq")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_seq")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string TransactionSequenceNumber { get; set; } = default!;
            }
        }
    }
}
