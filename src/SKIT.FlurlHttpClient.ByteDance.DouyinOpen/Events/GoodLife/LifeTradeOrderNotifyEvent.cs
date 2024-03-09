namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 life_trade_order_notify 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://partner.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/life-service-open-ability/life.capacity/order.query/trade.order.notify ]]>
    /// </para>
    /// </summary>
    public class LifeTradeOrderNotifyEvent : DouyinOpenEvent<LifeTradeOrderNotifyEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AccountId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置售卖价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int OriginalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置用户支付价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置下单时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置支付时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("action")]
                [System.Text.Json.Serialization.JsonPropertyName("action")]
                public string Action { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msg_time")]
                [System.Text.Json.Serialization.JsonPropertyName("msg_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public Types.Order Order { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public override Types.Content EventContent { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }
    }
}
