namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_merchantcode_status 接口的请求。</para>
    /// </summary>
    public class AuthEntityQueryMerchantCodeStatusRequest : ByteDanceMicroAppRoleApiRequest
    {
        /// <summary>
        /// 获取或设置证件号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置行业编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public int IndustryCode { get; set; }

        /// <summary>
        /// 获取或设置行业角色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
        public int IndustryRole { get; set; }

        /// <summary>
        /// 获取或设置商家商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
        public string? MerchantCode { get; set; }
    }
}
