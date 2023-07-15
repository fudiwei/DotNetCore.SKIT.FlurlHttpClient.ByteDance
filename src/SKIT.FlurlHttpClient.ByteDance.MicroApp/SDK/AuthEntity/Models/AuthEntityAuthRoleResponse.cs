namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityAuthRoleResponse : ByteDanceMicroAppAuthEntityResponse
    {
        [Newtonsoft.Json.JsonProperty("bind_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_taskid")]
        public string BindTaskId { get; set; } = string.Empty;
    }
}
