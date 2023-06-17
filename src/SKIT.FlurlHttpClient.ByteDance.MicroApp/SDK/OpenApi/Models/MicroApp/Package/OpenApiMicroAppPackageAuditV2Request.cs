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

        /// <summary>
        /// 本次提审的备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditNote")]
        [System.Text.Json.Serialization.JsonPropertyName("auditNote")]
        public string? AuditNote { get; set; }

        /// <summary>
        /// 是否用上次失败的版本重新提审，不传或传0表示正常提审，传1表示用上次审核失败的版本重新提审。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditWay")]
        [System.Text.Json.Serialization.JsonPropertyName("auditWay")]
        public int? AuditWay { get; set; }
    }
}
