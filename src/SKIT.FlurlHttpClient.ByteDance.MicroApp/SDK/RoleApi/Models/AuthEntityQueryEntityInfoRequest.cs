namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_entity_info 接口的请求。</para>
    /// </summary>
    public class AuthEntityQueryEntityInfoRequest : ByteDanceMicroAppRoleApiRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置证件号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; } = string.Empty;
    }
}
