namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/order/query_order 接口的请求。</para>
    /// </summary>
    public class AppsTradeOrderQueryOrderV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置开发者订单号。与字段 <see cref="OrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="OutOrderNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }
    }
}
