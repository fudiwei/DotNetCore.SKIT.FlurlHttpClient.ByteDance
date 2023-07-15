namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityQueryEntityInfoRequest : ByteDanceMicroAppAuthEntityRequest
    {

        /// <summary>
        /// 小程序app_id (注意该接口小程序id为下划线格式)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public override string? AppId { get; set; }
        /// <summary>
        /// 证件ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; } = string.Empty;
    }
}
