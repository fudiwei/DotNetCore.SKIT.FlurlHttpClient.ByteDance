namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/auth/pre_auth_code 接口的响应。</para>
    /// </summary>
    public class OpenApiAuthPreAuthCodeV2Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        /// <summary>
        /// 获取或设置预授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pre_auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("pre_auth_code")]
        public string PreAuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置预授权码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
