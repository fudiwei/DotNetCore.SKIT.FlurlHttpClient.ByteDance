namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ArbitrateDiscussUpload 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/31/628 </para>
    /// </summary>
    public class RefundArbitrateDiscussUploadEvent : TikTokShopEvent<RefundArbitrateDiscussUploadEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundArbitrateAppliedEvent.Types.Data
            {
            }
        }
    }
}
