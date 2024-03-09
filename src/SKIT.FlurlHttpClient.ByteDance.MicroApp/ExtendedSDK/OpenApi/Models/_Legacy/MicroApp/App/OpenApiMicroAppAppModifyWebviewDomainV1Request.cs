using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_webview_domain 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-23 下线。")]
    public class OpenApiMicroAppAppModifyWebviewDomainV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置执行动作。
        /// <para>默认值："get"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get";

        /// <summary>
        /// 获取或设置 Webview 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("webview")]
        [System.Text.Json.Serialization.JsonPropertyName("webview")]
        public IList<string>? WebviewDomainList { get; set; }
    }
}
