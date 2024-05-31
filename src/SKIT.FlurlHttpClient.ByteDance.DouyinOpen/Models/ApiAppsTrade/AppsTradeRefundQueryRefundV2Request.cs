namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/refund/query_refund 接口的请求。</para>
    /// </summary>
    public class AppsTradeRefundQueryRefundV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="OutRefundNumber"/>、<see cref="RefundId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置开发者退款单号。与字段 <see cref="OrderId"/>、<see cref="RefundId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string? OutRefundNumber { get; set; }

        /// <summary>
        /// 获取或设置退款单号。与字段 <see cref="OrderId"/>、<see cref="OutRefundNumber"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string? RefundId { get; set; }
    }
}
