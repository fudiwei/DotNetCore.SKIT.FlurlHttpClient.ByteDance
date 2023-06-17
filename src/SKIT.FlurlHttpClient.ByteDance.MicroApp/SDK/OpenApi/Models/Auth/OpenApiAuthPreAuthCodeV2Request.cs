namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/auth/pre_auth_code 接口的请求。</para>
    /// </summary>
    public class OpenApiAuthPreAuthCodeV2Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 预授权码类型 1: 仅授权 2: 代创建+授权 不传默认为1 
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code_type")]
        public int PreAuthCodeType { get; set; } = 1;

        /// <summary>
        /// 代创建的小程序名称，当预授权码为2时必填
        /// 会占用该小程序名称24小时，若超时未授权则会自动释放
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_name")]
        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// 代创建的小程序图标
        /// 需要使用第三方小程序应用上传资源接口返回的路径才可以，接口调用时入参 material_type 字段为 2，否则报错
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_icon")]
        [System.Text.Json.Serialization.JsonPropertyName("app_icon")]
        public string? AppIcon { get; set; }
    }
}
