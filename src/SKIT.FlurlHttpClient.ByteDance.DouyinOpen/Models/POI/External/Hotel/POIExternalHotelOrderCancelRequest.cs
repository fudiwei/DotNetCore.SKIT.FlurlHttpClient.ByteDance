namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/ext/hotel/order/cancel 接口的请求。</para>
    /// </summary>
    public class POIExternalHotelOrderCancelRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ext_id")]
        public string OrderExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_ext_id")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_ext_id")]
        public string SupplierExternalId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单支付状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int Status { get; set; }
    }
}
