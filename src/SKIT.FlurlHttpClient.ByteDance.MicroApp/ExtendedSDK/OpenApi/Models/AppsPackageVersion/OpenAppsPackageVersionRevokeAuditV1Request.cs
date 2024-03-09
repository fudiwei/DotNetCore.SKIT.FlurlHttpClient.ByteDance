using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/package_version/revoke_audit/ 接口的请求。</para>
    /// </summary>
    public class OpenAppsPackageVersionRevokeAuditV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置本次提审的宿主端列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("host_names")]
        [System.Text.Json.Serialization.JsonPropertyName("host_names")]
        public IList<string> HostNames { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置本次提审的备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_note")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_note")]
        public string? AuditNote { get; set; }

        /// <summary>
        /// 获取或设置重新提审方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_way")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_way")]
        public int? AuditWay { get; set; }

        /// <summary>
        /// 获取或设置版本通道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("TpAppID")]
        [System.Text.Json.Serialization.JsonPropertyName("TpAppID")]
        public override string? ComponentAppId { get; set; }
    }
}
