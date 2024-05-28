namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/close_pay_order/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperClosePayOrderV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置扣款单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
        public string PayOrderId { get; set; } = string.Empty;
    }
}
