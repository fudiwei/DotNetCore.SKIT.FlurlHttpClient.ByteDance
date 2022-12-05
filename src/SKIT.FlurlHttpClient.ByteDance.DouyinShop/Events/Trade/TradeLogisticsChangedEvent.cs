namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradeLogisticsChanged 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/30/113 </para>
    /// </summary>
    public class TradeLogisticsChangedEvent : DouyinShopEvent<TradeLogisticsChangedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : TradePartlySellerShipEvent.Types.Data
            {
            }
        }
    }
}
