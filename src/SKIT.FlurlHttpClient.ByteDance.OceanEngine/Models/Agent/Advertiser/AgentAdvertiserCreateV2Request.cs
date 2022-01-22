namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/agent/advertiser/create_v2 接口的请求。</para>
    /// </summary>
    public class AgentAdvertiserCreateV2Request : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置代理商 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 获取或设置账户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company")]
        [System.Text.Json.Serialization.JsonPropertyName("company")]
        public string Company { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置角色。
        /// <para>默认值：ROLE_CHILD_ADVERTISER</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("role")]
        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "ROLE_CHILD_ADVERTISER";

        /// <summary>
        /// 获取或设置账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_source")]
        [System.Text.Json.Serialization.JsonPropertyName("account_source")]
        public string? AccountSource { get; set; }

        /// <summary>
        /// 获取或设置营销区域。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_area")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_area")]
        public string PromotionArea { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营销中心省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_province")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_province")]
        public int PromotionProvinceCode { get; set; }

        /// <summary>
        /// 获取或设置营销中心城市编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_city")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_city")]
        public int PromotionCityCode { get; set; }

        /// <summary>
        /// 获取或设置一级行业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_industry_id")]
        [System.Text.Json.Serialization.JsonPropertyName("first_industry_id")]
        public int FirstIndustryId { get; set; }

        /// <summary>
        /// 获取或设置二级行业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_industry_id")]
        [System.Text.Json.Serialization.JsonPropertyName("second_industry_id")]
        public int SecondIndustryId { get; set; }

        /// <summary>
        /// 获取或设置联系邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("email")]
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置联系人。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact")]
        [System.Text.Json.Serialization.JsonPropertyName("contact")]
        public string Contact { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        public string MobileNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置固话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("telephone")]
        public string? TeleNumber { get; set; }

        /// <summary>
        /// 获取或设置地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置执照类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_type")]
        [System.Text.Json.Serialization.JsonPropertyName("license_type")]
        public int LicenseType { get; set; }

        /// <summary>
        /// 获取或设置执照编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_no")]
        [System.Text.Json.Serialization.JsonPropertyName("license_no")]
        public string LicenseNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置执照省份编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_province")]
        [System.Text.Json.Serialization.JsonPropertyName("license_province")]
        public int LicenseProvinceCode { get; set; }

        /// <summary>
        /// 获取或设置执照城市编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license_city")]
        [System.Text.Json.Serialization.JsonPropertyName("license_city")]
        public int LicenseCityCode { get; set; }

        /// <summary>
        /// 获取或设置品牌/事业部。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public string? Brand { get; set; }
    }
}
