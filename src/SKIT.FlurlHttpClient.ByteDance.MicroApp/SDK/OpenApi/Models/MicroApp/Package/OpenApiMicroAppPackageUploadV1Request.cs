namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/package/upload 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppPackageUploadV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置提交 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 获取或设置版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_version")]
        [System.Text.Json.Serialization.JsonPropertyName("user_version")]
        public string UserVersion { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
        public string UserDesccription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配置的 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_json")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_json")]
        public string? ExtraJson { get; set; }
    }
}
