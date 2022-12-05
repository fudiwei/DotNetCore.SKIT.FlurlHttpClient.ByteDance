using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/poi/sync 接口的请求。</para>
    /// </summary>
    public class GoodLifePOISyncV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class BusinessPartnership
                    {
                        public static class Types
                        {
                            public class Authorization
                            {
                                /// <summary>
                                /// 获取或设置授权类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置授权函图片 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("urls")]
                                [System.Text.Json.Serialization.JsonPropertyName("urls")]
                                public IList<string> ImageUrlList { get; set; } = new List<string>();

                                /// <summary>
                                /// 获取或设置合作内容类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("agreement")]
                                [System.Text.Json.Serialization.JsonPropertyName("agreement")]
                                public int AgreementType { get; set; }

                                /// <summary>
                                /// 获取或设置生效日期字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("effective_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("effective_time")]
                                public string EffectiveDateString { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置失效日期字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("expiration")]
                                [System.Text.Json.Serialization.JsonPropertyName("expiration")]
                                public string? ExpireDateString { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置小程序 AppId 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("app_ids")]
                                public IList<string> AppIdList { get; set; } = new List<string>();
                            }
                        }

                        /// <summary>
                        /// 获取或设置授权信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorization")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorization")]
                        public Types.Authorization Authorization { get; set; } = new Types.Authorization();
                    }

                    public class POIClaimAuthorization
                    {
                        /// <summary>
                        /// 获取或设置认领函图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("urls")]
                        public IList<string> ImageUrlList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置生效日期字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("effective_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("effective_time")]
                        public string EffectiveDateString { get; set; } = string.Empty;
                    }

                    public class BusinessLicense
                    {
                        /// <summary>
                        /// 获取或设置是否使用 OCR。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_ocr")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_ocr")]
                        public bool IsUseOCR { get; set; }

                        /// <summary>
                        /// 获取或设置营业执照类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_type")]
                        public int? LicenseType { get; set; }

                        /// <summary>
                        /// 获取或设置公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                        public string? CompanyName { get; set; }

                        /// <summary>
                        /// 获取或设置统一信用代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_id")]
                        public string? LicenseNumber { get; set; }

                        /// <summary>
                        /// 获取或设置营业执照照片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_urls")]
                        public IList<string> LicenseImageUrlList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string? Province { get; set; }

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string? City { get; set; }

                        /// <summary>
                        /// 获取或设置经营地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置失效日期字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expiration")]
                        [System.Text.Json.Serialization.JsonPropertyName("expiration")]
                        public string? ExpireDateString { get; set; }
                    }

                    public class LegalPerson
                    {
                        /// <summary>
                        /// 获取或设置是否使用 OCR。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("use_ocr")]
                        [System.Text.Json.Serialization.JsonPropertyName("use_ocr")]
                        public bool IsUseOCR { get; set; }

                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置身份证号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_no")]
                        public string? IdCardNumber { get; set; }

                        /// <summary>
                        /// 获取或设置身份证正面照片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_front_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_front_url")]
                        public string IdCardFrontImageUrlList { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置身份证背面照片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_back_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_back_url")]
                        public string IdCardBackImageUrlList { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置失效日期字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id_card_expiration")]
                        [System.Text.Json.Serialization.JsonPropertyName("id_card_expiration")]
                        public string? ExpireDateString { get; set; }
                    }

                    public class Industry
                    {
                        public static class Types
                        {
                            public class Qualification
                            {
                                /// <summary>
                                /// 获取或设置许可证 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
                                public string QualificationId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置许可证类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
                                public int QualificationType { get; set; }

                                /// <summary>
                                /// 获取或设置许可证照片 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_urls")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_urls")]
                                public IList<string> QualificationImageUrlList { get; set; } = new List<string>();

                                /// <summary>
                                /// 获取或设置失效日期字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("qualification_expiration")]
                                [System.Text.Json.Serialization.JsonPropertyName("qualification_expiration")]
                                public string? ExpireDateString { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置主营类目代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("major_industry_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("major_industry_code")]
                        public string MajorIndustryCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置辅营类目代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("minor_industry_codes")]
                        [System.Text.Json.Serialization.JsonPropertyName("minor_industry_codes")]
                        public IList<string>? MajorIndustryCodeList { get; set; }

                        /// <summary>
                        /// 获取或设置许可证列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualifications")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                        public IList<Types.Qualification>? QualificationList { get; set; }
                    }

                    public class Owner
                    {
                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置职务。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("role")]
                        [System.Text.Json.Serialization.JsonPropertyName("role")]
                        public string? Role { get; set; }

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone")]
                        public string? MobileNumber { get; set; }

                        /// <summary>
                        /// 获取或设置邮箱地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        public string? Email { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置三方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                public string ThirdId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_id")]
                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                public string? AccountId { get; set; }

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string POIId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商服合作信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_partnership")]
                [System.Text.Json.Serialization.JsonPropertyName("business_partnership")]
                public Types.BusinessPartnership? BusinessPartnership { get; set; }

                /// <summary>
                /// 获取或设置门店认领信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_claim_authorization")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_claim_authorization")]
                public Types.POIClaimAuthorization? POIClaimAuthorization { get; set; }

                /// <summary>
                /// 获取或设置营业执照信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license")]
                [System.Text.Json.Serialization.JsonPropertyName("license")]
                public Types.BusinessLicense? BusinessLicense { get; set; }

                /// <summary>
                /// 获取或设置法人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public Types.LegalPerson? LegalPerson { get; set; }

                /// <summary>
                /// 获取或设置行业信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry")]
                [System.Text.Json.Serialization.JsonPropertyName("industry")]
                public Types.Industry? Industry { get; set; }

                /// <summary>
                /// 获取或设置所有人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("owner")]
                [System.Text.Json.Serialization.JsonPropertyName("owner")]
                public Types.Owner? Owner { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置目标类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_type")]
        [System.Text.Json.Serialization.JsonPropertyName("target_type")]
        public int TargetType { get; set; }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datas")]
        [System.Text.Json.Serialization.JsonPropertyName("datas")]
        public IList<Types.POI> POIList { get; set; } = new List<Types.POI>();
    }
}
