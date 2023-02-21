namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_webview_domain 接口的响应。</para>
    /// </summary>
    public class OpenApiMicroAppAppModifyWebviewDomainV1Response : ByteDanceMicroAppOpenApiResponse
    {
        /// <summary>
        /// 获取或设置 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[]? WebviewDomainList { get; set; }
    }
}
