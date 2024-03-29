using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/microapp/package/audit 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-02-21 下线。")]
    public class OpenApiMicroAppPackageAuditV2Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置本次提审的宿主端列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hostNames")]
        [System.Text.Json.Serialization.JsonPropertyName("hostNames")]
        public IList<string> HostNames { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置本次提审的备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditNote")]
        [System.Text.Json.Serialization.JsonPropertyName("auditNote")]
        public string? AuditNote { get; set; }

        /// <summary>
        /// 获取或设置重新提审方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditWay")]
        [System.Text.Json.Serialization.JsonPropertyName("auditWay")]
        public int? AuditWay { get; set; }
    }
}
