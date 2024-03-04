using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/info 接口的响应。</para>
    /// </summary>
    public class AdvertiserInfoResponse : OceanEngineResponse<AdvertiserInfoResponse.Types.Advertiser[]>
    {
        public static class Types
        {
            public class Advertiser
            {
                /// <summary>
                /// 获取或设置广告主 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long? AdvertiserId { get; set; }

                /// <summary>
                /// 获取或设置账户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role")]
                [System.Text.Json.Serialization.JsonPropertyName("role")]
                public string? Role { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string? Status { get; set; }

                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置营业执照 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_url")]
                [System.Text.Json.Serialization.JsonPropertyName("license_url")]
                public string? LicenseUrl { get; set; }

                /// <summary>
                /// 获取或设置营业执照编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_no")]
                [System.Text.Json.Serialization.JsonPropertyName("license_no")]
                public string? LicenseNumber { get; set; }

                /// <summary>
                /// 获取或设置营业执照省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_province")]
                [System.Text.Json.Serialization.JsonPropertyName("license_province")]
                public string? LicenseProvince { get; set; }

                /// <summary>
                /// 获取或设置营业执照城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license_city")]
                [System.Text.Json.Serialization.JsonPropertyName("license_city")]
                public string? LicenseCity { get; set; }

                /// <summary>
                /// 获取或设置公司名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company")]
                [System.Text.Json.Serialization.JsonPropertyName("company")]
                public string? Company { get; set; }

                /// <summary>
                /// 获取或设置经营类别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand")]
                [System.Text.Json.Serialization.JsonPropertyName("brand")]
                public string? Brand { get; set; }

                /// <summary>
                /// 获取或设置运营区域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_area")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_area")]
                public string? PromotionArea { get; set; }

                /// <summary>
                /// 获取或设置运营省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_center_province")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_center_province")]
                public string? PromotionCenterProvince { get; set; }

                /// <summary>
                /// 获取或设置运营城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_center_city")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_center_city")]
                public string? PromotionCenterCity { get; set; }

                /// <summary>
                /// 获取或设置一级行业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_industry_name")]
                [System.Text.Json.Serialization.JsonPropertyName("first_industry_name")]
                public string? FirstIndustryName { get; set; }

                /// <summary>
                /// 获取或设置二级行业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_industry_name")]
                [System.Text.Json.Serialization.JsonPropertyName("second_industry_name")]
                public string? SecondIndustryName { get; set; }

                /// <summary>
                /// 获取或设置审核拒绝原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string? RejectReason { get; set; }

                /// <summary>
                /// 获取或设置注册时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset? CreateTime { get; set; }
            }
        }
    }
}
