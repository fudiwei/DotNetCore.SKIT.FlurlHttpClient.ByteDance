using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/microapp/package/audit 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppPackageAuditV2Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置本次需要审核的宿主端英文简称列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hostNames")]
        [System.Text.Json.Serialization.JsonPropertyName("hostNames")]
        public IList<string> HostNames { get; set; } = new List<string>();
    }
}
