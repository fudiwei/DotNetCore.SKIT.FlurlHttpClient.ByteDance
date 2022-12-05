namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradePending 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/30/277 </para>
    /// </summary>
    public class TradePendingEvent : DouyinShopEvent<TradePendingEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
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
            }
        }
    }
}
