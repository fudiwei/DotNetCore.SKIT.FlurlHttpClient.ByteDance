namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_pay_order/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperQueryPayOrderV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开发者扣款单号。与字段 <see cref="PayOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_pay_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_pay_order_no")]
        public string? OutPayOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置扣款单 ID。与字段 <see cref="OutPayOrderNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
        public string? PayOrderId { get; set; }
    }
}
