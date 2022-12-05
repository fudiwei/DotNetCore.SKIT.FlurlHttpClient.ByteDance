namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradeSellerShip 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/30/111 </para>
    /// </summary>
    public class TradeSellerShipEvent : DouyinShopEvent<TradeSellerShipEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : TradePartlySellerShipEvent.Types.Data
            {
            }
        }
    }
}
