namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /openapi/v2/auth/tp/token 接口的响应。</para>
    /// </summary>
    public class OpenApiAuthThirdPartyTokenV2Response : DouyinMicroAppOpenApiResponse
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override int ErrorNumber { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("component_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("component_access_token")]
        public string ComponentAccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置第三方平台 AccessToken 有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
