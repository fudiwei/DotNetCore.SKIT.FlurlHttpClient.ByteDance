namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityAddClassAuthResponse: ByteDanceMicroAppAuthEntityResponse
    {
        /// <summary>
        /// 审核任务ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_auth_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auth_taskid")]
        public string? ClassAuthTaskId { get; set; }
    }
}
