using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/microapp/app/modify_webview_domain 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppModifyWebviewDomainV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置执行动作。
        /// <para>默认值：get</para>
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
