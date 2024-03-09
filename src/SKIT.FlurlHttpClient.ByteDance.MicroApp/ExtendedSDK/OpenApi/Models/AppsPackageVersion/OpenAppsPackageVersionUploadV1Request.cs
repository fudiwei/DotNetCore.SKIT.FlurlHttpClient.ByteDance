namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/package_version/upload/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsPackageVersionUploadV1Request : DouyinMicroAppOpenApiRequest
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
        public string UserDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配置的 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_json")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_json")]
        public string? ExtraJson { get; set; }

        /// <summary>
        /// 获取或设置版本通道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? VersionTag { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("TpAppID")]
        [System.Text.Json.Serialization.JsonPropertyName("TpAppID")]
        public override string? ComponentAppId { get; set; }
    }
}
