namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /reverse/reverse_request/reject 接口的请求。</para>
    /// </summary>
    public class ReverseRejectReverseRequestRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置撤回订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_order_id")]
        public string ReverseOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒绝原因标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_reject_reason_key")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_reject_reason_key")]
        public string RejectReasonKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注释。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_reject_comments")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_reject_comments")]
        public string? RejectComments { get; set; }
    }
}
