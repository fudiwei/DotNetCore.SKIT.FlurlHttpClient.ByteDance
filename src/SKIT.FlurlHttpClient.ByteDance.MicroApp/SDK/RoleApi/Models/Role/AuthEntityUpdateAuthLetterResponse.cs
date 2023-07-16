namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /update_authletter 接口的响应。</para>
    /// </summary>
    public class AuthEntityUpdateAuthLetterResponse : ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置审核任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
        public string AuditTaskId { get; set; } = default!;
    }
}
