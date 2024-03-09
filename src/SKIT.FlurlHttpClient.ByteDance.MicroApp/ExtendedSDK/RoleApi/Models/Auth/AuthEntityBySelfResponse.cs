namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /byself 接口的响应。</para>
    /// </summary>
    public class AuthEntityBySelfResponse: DouyinMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置基础认证任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth_taskid")]
        public string BasicAuthTaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置类目审核任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auth_taskid")]
        public string ClassAuthTaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = default!;
    }
}
