namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityUploadMaterialResponse: ByteDanceMicroAppAuthEntityResponse
    {
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }
    }
}
