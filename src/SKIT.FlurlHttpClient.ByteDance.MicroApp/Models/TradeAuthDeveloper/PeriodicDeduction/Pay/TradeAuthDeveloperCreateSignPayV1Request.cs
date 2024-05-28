namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/create_sign_pay/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperCreateSignPayV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置签约单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_order_id")]
        public string AuthOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者扣款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_pay_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_pay_order_no")]
        public string OutPayOrderNumber { get; set; } = string.Empty;

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
        /// 获取或设置回调通知 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置代扣超时时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_seconds")]
        public int? ExpiresIn { get; set; }
    }
}
