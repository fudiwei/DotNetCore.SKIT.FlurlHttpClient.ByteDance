namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /reverse/reverse_request/confirm 接口的请求。</para>
    /// </summary>
    public class ReverseConfirmReverseRequestRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置撤回订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_order_id")]
        public string ReverseOrderId { get; set; } = string.Empty;
    }
}
