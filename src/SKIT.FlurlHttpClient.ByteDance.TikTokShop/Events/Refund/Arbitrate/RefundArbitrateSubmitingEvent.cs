namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ArbitrateSubmiting 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/31/257 </para>
    /// </summary>
    public class RefundArbitrateSubmitingEvent : TikTokShopEvent<RefundArbitrateSubmitingEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundArbitrateAppliedEvent.Types.Data
            {
            }
        }
    }
}
