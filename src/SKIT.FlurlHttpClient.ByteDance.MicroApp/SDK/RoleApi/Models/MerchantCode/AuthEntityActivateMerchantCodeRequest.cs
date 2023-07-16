namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /activate_merchantcode 接口的请求。</para>
    /// </summary>
    public class AuthEntityActivateMerchantCodeRequest : ByteDanceMicroAppRoleApiRequest
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
        /// 获取或设置激活认证状态回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 获取或设置商家商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
        public string? MerchantCode { get; set; }
    }
}
