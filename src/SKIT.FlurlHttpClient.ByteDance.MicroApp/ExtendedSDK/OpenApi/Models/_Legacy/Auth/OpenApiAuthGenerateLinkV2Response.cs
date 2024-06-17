namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/auth/gen_link 接口的响应。</para>
    /// </summary>
    public class OpenApiAuthGenerateLinkV2Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        /// <summary>
        /// 获取或设置授权链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("link")]
        [System.Text.Json.Serialization.JsonPropertyName("link")]
        public string AuthLink { get; set; } = default!;
    }
}
