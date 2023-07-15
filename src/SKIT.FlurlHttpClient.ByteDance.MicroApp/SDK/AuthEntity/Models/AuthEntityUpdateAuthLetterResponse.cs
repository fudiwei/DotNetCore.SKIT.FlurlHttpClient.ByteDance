namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityUpdateAuthLetterResponse : ByteDanceMicroAppAuthEntityResponse
    {
        [Newtonsoft.Json.JsonProperty("audit_taskid")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
        public string AuditTaskId { get; set; } = string.Empty;
    }
}
