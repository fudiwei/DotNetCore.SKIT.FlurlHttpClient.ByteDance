namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ArbitrateSubmiting 消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://op.jinritemai.com/docs/message-docs/31/257 ]]>
    /// </para>
    /// </summary>
    public class RefundArbitrateSubmitingEvent : DouyinShopEvent<RefundArbitrateSubmitingEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundArbitrateAppliedEvent.Types.Data
            {
            }
        }
    }
}
