using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/settle/apply 接口的请求。</para>
    /// </summary>
    public class OpenApiSettleApplyV1Request : DouyinMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string MobileNumber { get; set; } = string.Empty;

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
        /// 获取或设置营业执照照片文件路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("credit_image_path")]
        [System.Text.Json.Serialization.JsonPropertyName("credit_image_path")]
        public string BusinessLicenseImageFilePath { get; set; } = string.Empty;

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

        /// <summary>
        /// 获取或设置经营行业类目编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedNumberListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("category_code")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedNumberListWithCommaSplitConverter))]
        public IList<int> CategoryCodeList { get; set; } = new List<int>();

        /// <summary>
        /// 获取或设置运营人员姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_person_name")]
        [System.Text.Json.Serialization.JsonPropertyName("business_person_name")]
        public string BusinessPersonName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运营人员身份证号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id_card")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id_card")]
        public string BusinessIdCardNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运营人员手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("business_mobile")]
        public string BusinessMobileNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("company_introduction")]
        public string? CompanyIntroduction { get; set; }

        /// <summary>
        /// 获取或设置经营地址省份编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_province_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_province_code")]
        public int? BusinessProvinceCode { get; set; }

        /// <summary>
        /// 获取或设置经营地址城市编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_city_code")]
        [System.Text.Json.Serialization.JsonPropertyName("business_city_code")]
        public int? BusinessCityCode { get; set; }

        /// <summary>
        /// 获取或设置经营地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_address")]
        [System.Text.Json.Serialization.JsonPropertyName("business_address")]
        public string? BusinessAddress { get; set; }

        /// <summary>
        /// 获取或设置员工总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("employee_count")]
        [System.Text.Json.Serialization.JsonPropertyName("employee_count")]
        public int? EmployeeCount { get; set; }

        /// <summary>
        /// 获取或设置官网地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_website")]
        [System.Text.Json.Serialization.JsonPropertyName("company_website")]
        public string? CompanyWebsite { get; set; }
    }
}
