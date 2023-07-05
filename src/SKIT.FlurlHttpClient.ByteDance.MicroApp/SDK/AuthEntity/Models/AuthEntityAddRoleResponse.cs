namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityAddRoleResponse: ByteDanceMicroAppAuthEntityResponse
    {
        /// <summary>
        /// 类目认证任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("add_role_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("add_role_taskid")]
        public string? AddRoleTaskId { get; set; }

    }
}
