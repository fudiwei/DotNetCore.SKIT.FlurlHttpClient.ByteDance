using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/advertiser/qualification/submit 接口的请求。</para>
    /// </summary>
    public class AdvertiserQualificationSubmitRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Subject
            {
                /// <summary>
                /// 获取或设置资质 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_id")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
                public int QualificationId { get; set; }

                /// <summary>
                /// 获取或设置公司名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string CompanyName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置公司类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_type")]
                [System.Text.Json.Serialization.JsonPropertyName("company_type")]
                public int CompanyType { get; set; }

                /// <summary>
                /// 获取或设置对公验证类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("check_type")]
                [System.Text.Json.Serialization.JsonPropertyName("check_type")]
                public int CheckType { get; set; }

                /// <summary>
                /// 获取或设置资质类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_type")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                public int QualificationType { get; set; }

                /// <summary>
                /// 获取或设置资质编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_code")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_code")]
                public string QualificationCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置注册国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registered_nation_name")]
                [System.Text.Json.Serialization.JsonPropertyName("registered_nation_name")]
                public string RegisteredNationName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置注册省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registered_province_name")]
                [System.Text.Json.Serialization.JsonPropertyName("registered_province_name")]
                public string RegisteredProvinceName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置注册城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("registered_city_name")]
                [System.Text.Json.Serialization.JsonPropertyName("registered_city_name")]
                public string RegisteredCityName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否有有效日期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_effective_date")]
                [System.Text.Json.Serialization.JsonPropertyName("has_effective_date")]
                public bool HasEffectiveDate { get; set; }

                /// <summary>
                /// 获取或设置过期时间字符串（格式：yyyy-mm-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effective_date")]
                [System.Text.Json.Serialization.JsonPropertyName("effective_date")]
                public string? EffectiveDateString { get; set; }

                /// <summary>
                /// 获取或设置法人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proprietor_name")]
                [System.Text.Json.Serialization.JsonPropertyName("proprietor_name")]
                public string ProprietorName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置资质图片附件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attachment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("attachment_id")]
                public string? AttachmentId { get; set; }
            }

            public class OtherQualification
            {
                /// <summary>
                /// 获取或设置资质 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_id")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
                public int QualificationId { get; set; }

                /// <summary>
                /// 获取或设置资质图片附件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attachment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("attachment_id")]
                public string? AttachmentId { get; set; }
            }

            public class PromotionQualification
            {
                /// <summary>
                /// 获取或设置推广内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置主体信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public Types.Subject Subject { get; set; } = new Types.Subject();

        /// <summary>
        /// 获取或设置开户资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("others")]
        [System.Text.Json.Serialization.JsonPropertyName("others")]
        public IList<Types.OtherQualification> OtherQualificationList { get; set; } = new List<Types.OtherQualification>();

        /// <summary>
        /// 获取或设置推广资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion")]
        public Types.PromotionQualification PromotionQualification { get; set; } = new Types.PromotionQualification();
    }
}
