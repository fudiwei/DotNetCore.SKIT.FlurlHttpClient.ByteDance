namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradeLogisticsChanged 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/30/113 </para>
    /// </summary>
    public class TradeLogisticsChangedEvent : TikTokShopEvent<TradeLogisticsChangedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : TradePartlySellerShipEvent.Types.Data
            {
            }
        }
    }
}
