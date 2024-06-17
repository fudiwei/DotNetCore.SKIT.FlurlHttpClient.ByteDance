using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_webview_domain 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiMicroAppAppModifyWebviewDomainV1Response : DouyinMicroAppOpenApiLegacyResponseBase
    {
        /// <summary>
        /// 获取或设置 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[]? WebviewDomainList { get; set; }
    }
}
