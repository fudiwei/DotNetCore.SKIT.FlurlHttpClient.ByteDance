namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradeAddressChangeApplied 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/30/285 </para>
    /// </summary>
    public class TradeAddressChangeAppliedEvent : DouyinShopEvent<TradeAddressChangeAppliedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Receiver : TradePartlySellerShipEvent.Types.Data.Types.Receiver
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商铺订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("p_id")]
                [System.Text.Json.Serialization.JsonPropertyName("p_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string ShopOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public int ShopId { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                public long ApplyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置变更前的收货人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("post_receiver_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("post_receiver_msg")]
                public Types.Receiver PreviousReceiver { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请变更的收货人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_msg")]
                public Types.Receiver CurrentReceiver { get; set; } = default!;
            }
        }
    }
}
