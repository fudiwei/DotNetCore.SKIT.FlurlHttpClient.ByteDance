using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/modify_server_domain 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppModifyServerDomainV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置执行动作。
        /// <para>默认值：get</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get";

        /// <summary>
        /// 获取或设置 HTTP 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request")]
        [System.Text.Json.Serialization.JsonPropertyName("request")]
        public IList<string>? RequestDomainList { get; set; }

        /// <summary>
        /// 获取或设置 WebSocket 域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("socket")]
        [System.Text.Json.Serialization.JsonPropertyName("socket")]
        public IList<string>? SocketDomainList { get; set; }

        /// <summary>
        /// 获取或设置上传域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload")]
        [System.Text.Json.Serialization.JsonPropertyName("upload")]
        public IList<string>? UploadDomainList { get; set; }

        /// <summary>
        /// 获取或设置下载域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download")]
        [System.Text.Json.Serialization.JsonPropertyName("download")]
        public IList<string>? DownloadDomainList { get; set; }
    }
}
