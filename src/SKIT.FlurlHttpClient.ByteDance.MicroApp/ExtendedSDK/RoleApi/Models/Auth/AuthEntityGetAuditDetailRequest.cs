namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_audit_detail 接口的请求。</para>
    /// </summary>
    public class AuthEntityGetAuditDetailRequest : DouyinMicroAppRoleApiRequest
    {
        /// <summary>
        /// 获取或设置审核类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_type")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public int AuthType { get; set; }

        /// <summary>
        /// 获取或设置审核任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_taskid")]
        public string AuthTaskId { get; set; } = string.Empty;
    }
}
