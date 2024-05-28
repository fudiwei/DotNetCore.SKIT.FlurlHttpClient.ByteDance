namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_sign_pay/ 接口的响应。</para>
    /// </summary>
    public class TradeAuthDeveloperQuerySignPayV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置签约单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
                public string AuthOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发者扣款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_pay_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_pay_order_no")]
                public string OutPayOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置扣款单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
                public string PayOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置扣款单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置扣款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置回调通知地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
                public string? NotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置支付渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_channel")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_channel")]
                public int? PayChannel { get; set; }

                /// <summary>
                /// 获取或设置渠道支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_pay_id")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_pay_id")]
                public string? ChannelPayId { get; set; }

                /// <summary>
                /// 获取或设置支付时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimeMilliseconds { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
