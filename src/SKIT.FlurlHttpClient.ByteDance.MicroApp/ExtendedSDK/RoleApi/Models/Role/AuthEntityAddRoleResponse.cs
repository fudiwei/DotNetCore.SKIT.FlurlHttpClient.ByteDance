namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /add_role 接口的响应。</para>
    /// </summary>
    public class AuthEntityAddRoleResponse : DouyinMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置类目认证任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_role_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("add_role_taskid")]
        public string AddRoleTaskId { get; set; } = default!;
    }
}
