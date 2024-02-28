namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradeAddressChanged 消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://op.jinritemai.com/docs/message-docs/30/114 ]]>
    /// </para>
    /// </summary>
    public class TradeAddressChangedEvent : DouyinShopEvent<TradeAddressChangedEvent.Types.Data>
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
                /// 获取或设置商品单号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("s_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("s_ids")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringArrayConverter))]
                public string[] SKUOrderIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public int ShopId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置业务来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz")]
                [System.Text.Json.Serialization.JsonPropertyName("biz")]
                public int BusinessType { get; set; }

                /// <summary>
                /// 获取或设置收货信息变更时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置收货人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_msg")]
                public Types.Receiver Receiver { get; set; } = default!;
            }
        }
    }
}
