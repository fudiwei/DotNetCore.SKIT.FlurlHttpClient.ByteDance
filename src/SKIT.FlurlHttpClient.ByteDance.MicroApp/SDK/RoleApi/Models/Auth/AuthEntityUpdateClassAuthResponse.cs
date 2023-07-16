namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /update_class_auth 接口的响应。</para>
    /// </summary>
    public class AuthEntityUpdateClassAuthResponse: ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置类目审核任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auth_taskid")]
        public string ClassAuthTaskId { get; set; } = default!;
    }
}
