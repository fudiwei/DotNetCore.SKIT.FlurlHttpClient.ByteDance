namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /poi/order/confirm/cancel_prepare 接口的请求。</para>
    /// </summary>
    public class POIOrderConfirmCancelPrepareRequest : DouyinOpenRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public override string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置核销单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("confirm_apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("confirm_apply_id")]
        public string ConfirmApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置取消原因。
        /// <para>默认值：USER_CANCEL</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; } = "USER_CANCEL";
    }
}
