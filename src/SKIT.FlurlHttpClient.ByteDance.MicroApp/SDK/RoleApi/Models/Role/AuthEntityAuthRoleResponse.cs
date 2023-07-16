namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /auth_role 接口的响应。</para>
    /// </summary>
    public class AuthEntityAuthRoleResponse : ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置绑定审核任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_taskid")]
        public string? BindTaskId { get; set; } 
    }
}
