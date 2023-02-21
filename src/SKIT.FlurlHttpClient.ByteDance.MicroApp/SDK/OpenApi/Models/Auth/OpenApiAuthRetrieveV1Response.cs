namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /v1/auth/retrieve 接口的响应。</para>
    /// </summary>
    public class OpenApiAuthRetrieveV1Response : ByteDanceMicroAppOpenApiResponse
    {
        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorization_code")]
        [System.Text.Json.Serialization.JsonPropertyName("authorization_code")]
        public string AuthCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权码有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
