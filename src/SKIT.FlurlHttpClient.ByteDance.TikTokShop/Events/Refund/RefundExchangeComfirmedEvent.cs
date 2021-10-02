namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ExchangeComfirmed 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/31/240 </para>
    /// </summary>
    public class RefundExchangeComfirmedEvent : TikTokShopEvent<RefundExchangeComfirmedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundCreatedEvent.Types.Data
            {
            }
        }
    }
}
