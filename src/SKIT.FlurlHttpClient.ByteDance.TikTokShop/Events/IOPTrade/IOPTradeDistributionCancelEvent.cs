namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_iopTrade_DistributionCancel 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/65/682 </para>
    /// </summary>
    public class IOPTradeDistributionCancelEvent : TikTokShopEvent<IOPTradeDistributionCancelEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : IOPTradeDistributionEvent.Types.Data
            {
            }
        }
    }
}
