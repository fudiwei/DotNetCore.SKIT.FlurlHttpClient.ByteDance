namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_iopTrade_UpdateRemark 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/65/679 </para>
    /// </summary>
    public class IOPTradeUpdateRemarkEvent : DouyinShopEvent<IOPTradeUpdateRemarkEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : IOPTradeDistributionEvent.Types.Data
            {
                /// <summary>
                /// 获取或设置卖家备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seller_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("seller_remark")]
                public string SellerRemark { get; set; } = default!;
            }
        }
    }
}
