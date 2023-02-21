namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/settle/pre_check 接口的请求。</para>
    /// </summary>
    public class OpenApiSettlePreCheckV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置主体类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_type")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
        public int QualificationType { get; set; }

        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_name")]
        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credit_code")]
        [System.Text.Json.Serialization.JsonPropertyName("credit_code")]
        public string BusinessLicenseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照有效期（格式：yyyy-MM-dd / "0"）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credit_end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("credit_end_date")]
        public string BusinessLicenseEndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_type")]
        [System.Text.Json.Serialization.JsonPropertyName("company_type")]
        public int CompanyType { get; set; }

        /// <summary>
        /// 获取或设置法人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_person_name")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_person_name")]
        public string LegalPersonName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册地址国家编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_nation_code")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_nation_code")]
        public int? RegisteredNationCode { get; set; }

        /// <summary>
        /// 获取或设置注册地址省份编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_province_code")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_province_code")]
        public int? RegisteredProvinceCode { get; set; }

        /// <summary>
        /// 获取或设置注册地址城市编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_city_code")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_city_code")]
        public int? RegisteredCityCode { get; set; }

        /// <summary>
        /// 获取或设置注册地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_address")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_address")]
        public string RegisteredAddress { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册资本（单位：元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_capital")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_capital")]
        public long RegisteredCapital { get; set; }
    }
}
