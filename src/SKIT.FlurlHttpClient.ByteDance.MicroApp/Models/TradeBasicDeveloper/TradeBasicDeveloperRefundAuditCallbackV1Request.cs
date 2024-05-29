namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/refund_audit_callback/ 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperRefundAuditCallbackV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = string.Empty;

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
