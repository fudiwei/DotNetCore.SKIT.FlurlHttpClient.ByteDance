namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/merchant_audit_callback 接口的请求。</para>
    /// </summary>
    public class AppsTradeMerchantAuditCallbackV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开发者退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_audit_status")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_audit_status")]
        public int AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置不同意退款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deny_message")]
        [System.Text.Json.Serialization.JsonPropertyName("deny_message")]
        public string? DenyMessage { get; set; }
    }
}
