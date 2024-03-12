namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /im/group/enter/audit/set/ 接口的请求。</para>
    /// </summary>
    public class IMGroupEnterAuditSetRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置入群申请 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public string ApplyId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
