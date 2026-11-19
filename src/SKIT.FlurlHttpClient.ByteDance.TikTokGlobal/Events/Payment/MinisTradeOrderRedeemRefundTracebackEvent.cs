namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Events
{
    /// <summary>
    /// <para>表示 "minis.trade_order.redeem.refund_traceback" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.tiktok.com/doc/in-app-purchases ]]> <br/>
    /// <![CDATA[ https://developers.tiktok.com/doc/tiktok-minis-in-app-purchases ]]>
    /// </para>
    /// </summary>
    public class MinisTradeOrderRedeemRefundTracebackEvent : TikTokV2Event<MinisTradeOrderRedeemRefundTracebackEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置交易订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_order_id")]
                public string? TradeOrderId { get; set; }

                /// <summary>
                /// 获取或设置退款数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置是否是沙箱环境。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_sandbox")]
                [System.Text.Json.Serialization.JsonPropertyName("is_sandbox")]
                public bool? IsSandbox { get; set; }
            }
        }
    }
}
