namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ArbitrateServiceIntervene 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/31/627 </para>
    /// </summary>
    public class RefundArbitrateServiceInterveneEvent : DouyinShopEvent<RefundArbitrateServiceInterveneEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundArbitrateAppliedEvent.Types.Data
            {
            }
        }
    }
}
