namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityQueryMerchantCodeStatusRequest : ByteDanceMicroAppAuthEntityRequest
    {
        /// <summary>
        /// 商家证件号ID(身份证或者营业执照)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; } = string.Empty;
        /// <summary>
        /// 行业
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public int IndustryCode { get; set; } = 0;
        /// <summary>
        /// 商家的行业角色(老师/机构/服务商)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
        public int IndustryRole { get; set; } = 0;
    }

    public class AuthEntityQueryMerchantCodeStatusResponse : ByteDanceMicroAppAuthEntityResponse
    {

        /// <summary>
        /// SUCCESS/PROCESSING/FAILED
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// 状态描述
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; } = string.Empty;
    }
}