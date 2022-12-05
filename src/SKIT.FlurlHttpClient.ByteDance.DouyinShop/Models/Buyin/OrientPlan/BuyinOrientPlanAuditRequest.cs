namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/orienPlanAudit 接口的请求。</para>
    /// </summary>
    public class BuyinOrientPlanAuditRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public int ApplyId { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_action")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_action")]
        public int Action { get; set; }
    }
}
