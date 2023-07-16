namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /update_basic_auth 接口的响应。</para>
    /// </summary>
    public class AuthEntityUpdateBasicAuthResponse: ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置基础认证任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth_taskid")]
        public string BasicAuthTaskId { get; set; } = default!;
    }
}
