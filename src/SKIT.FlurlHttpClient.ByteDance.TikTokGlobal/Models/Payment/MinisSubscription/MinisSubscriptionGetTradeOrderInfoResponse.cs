namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/get_trade_order_info/ 接口的响应。</para>
    /// </summary>
    public class MinisSubscriptionGetTradeOrderInfoResponse : TikTokV2Response<MinisSubscriptionGetTradeOrderInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置订阅 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscription_id")]
                [System.Text.Json.Serialization.JsonPropertyName("subscription_id")]
                public string? SubscriptionId { get; set; }

                /// <summary>
                /// 获取或设置交易订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_order_id")]
                public string? TradeOrderId { get; set; }

                /// <summary>
                /// 获取或设置交易订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_order_status")]
                public string? TradeOrderStatus { get; set; }

                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestampMilli { get; set; }

                /// <summary>
                /// 获取或设置结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestampMilli { get; set; }

                /// <summary>
                /// 获取或设置实际结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actually_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("actually_end_time")]
                public long ActualEndTimestampMilli { get; set; }

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                public string? PayType { get; set; }

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
