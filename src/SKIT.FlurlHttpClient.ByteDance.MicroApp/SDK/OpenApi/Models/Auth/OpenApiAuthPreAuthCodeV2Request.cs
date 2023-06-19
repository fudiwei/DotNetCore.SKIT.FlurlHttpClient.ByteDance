namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/auth/pre_auth_code 接口的请求。</para>
    /// </summary>
    public class OpenApiAuthPreAuthCodeV2Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置预授权码类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code_type")]
        public int? PreAuthCodeType { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// 获取或设置代创建的小程序图标路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_icon")]
        [System.Text.Json.Serialization.JsonPropertyName("app_icon")]
        public string? AppIconPath { get; set; }
    }
}
