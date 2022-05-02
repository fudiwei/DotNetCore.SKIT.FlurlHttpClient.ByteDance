using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /openapi/v1/microapp/package/audit 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppPackageAuditV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置第三方应用 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置本次需要审核的宿主端英文简称列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hostNames")]
        [System.Text.Json.Serialization.JsonPropertyName("hostNames")]
        public IList<string> HostNames { get; set; } = new List<string>();
    }
}
