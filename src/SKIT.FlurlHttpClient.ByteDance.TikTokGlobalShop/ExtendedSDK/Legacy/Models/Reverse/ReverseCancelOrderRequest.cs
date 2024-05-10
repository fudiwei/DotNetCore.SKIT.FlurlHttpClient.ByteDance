namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /reverse/order/cancel 接口的请求。</para>
    /// </summary>
    public class ReverseCancelOrderRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置取消原因标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason_key")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason_key")]
        public string CancelReasonKey { get; set; } = string.Empty;
    }
}
