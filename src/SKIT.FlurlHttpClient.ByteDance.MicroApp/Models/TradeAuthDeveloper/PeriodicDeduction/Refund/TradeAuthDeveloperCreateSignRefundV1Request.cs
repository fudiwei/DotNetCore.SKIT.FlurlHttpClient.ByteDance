namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/create_sign_refund/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperCreateSignRefundV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置扣款单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
        public string PayOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_pay_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_pay_refund_no")]
        public string OutPayRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_total_amount")]
        public int RefundTotalAmount { get; set; }

        /// <summary>
        /// 获取或设置退款原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public string? RefundReason { get; set; }

        /// <summary>
        /// 获取或设置回调通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
