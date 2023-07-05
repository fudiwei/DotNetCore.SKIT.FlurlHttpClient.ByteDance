namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityBySelfResponse: ByteDanceMicroAppAuthEntityResponse
    {
        /// <summary>
        /// 基础认证任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth_taskid")]
        public string BasicAuthTaskId { get; set; } = string.Empty;

        /// <summary>
        /// 审核任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auth_taskid")]
        public string ClassAuthTaskId { get; set; } = string.Empty;

        /// <summary>
        /// 实体ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;

    }
}
