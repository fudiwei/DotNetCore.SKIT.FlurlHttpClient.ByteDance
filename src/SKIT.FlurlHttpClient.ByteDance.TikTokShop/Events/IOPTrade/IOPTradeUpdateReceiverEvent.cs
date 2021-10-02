namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_iopTrade_UpdateReceiver 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/65/682 </para>
    /// </summary>
    public class IOPTradeUpdateReceiverEvent : TikTokShopEvent<IOPTradeUpdateReceiverEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : IOPTradeDistributionEvent.Types.Data
            {
            }
        }
    }
}
