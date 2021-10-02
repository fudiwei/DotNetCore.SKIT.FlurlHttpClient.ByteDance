namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_iopTrade_StatusReturn 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/65/683 </para>
    /// </summary>
    public class IOPTradeStatusReturnEvent : TikTokShopEvent<IOPTradeStatusReturnEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : IOPTradeDistributionEvent.Types.Data
            {
                /// <summary>
                /// 获取或设置回传状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_status")]
                [System.Text.Json.Serialization.JsonPropertyName("return_status")]
                public int ReturnStatus { get; set; }
            }
        }
    }
}
