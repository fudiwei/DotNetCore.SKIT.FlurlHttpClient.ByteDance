using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /add_qualification 接口的请求。</para>
    /// </summary>
    public class ProductApiAddQualificationRequest : ByteDanceMicroAppProductApiRequest
    {
        public static class Types
        {
            public class Qualification
            {
                public static class Types
                {
                    public class TeacherQualification
                    {
                        public static class Types
                        {
                            public class DouyinAuthInfo
                            {
                                /// <summary>
                                /// 获取或设置抖音开放平台 ClientKey。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("client_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("client_key")]
                                public string ClientKey { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置抖音开放平台用户的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("open_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                                public string OpenId { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                        public int? FirstClassId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                        public int? SecondClassId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                        public int? ThirdClassId { get; set; }

                        /// <summary>
                        /// 获取或设置身份证号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ID_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("ID_number")]
                        public string IdCardNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置身份证照片资源路径列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ID_img_uris")]
                        [System.Text.Json.Serialization.JsonPropertyName("ID_img_uris")]
                        public IList<string> IdCardImagePathList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置照片资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_uri")]
                        public string? ImagePath { get; set; }

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("introduction")]
                        public string Introduction { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_info_lst")]
                        public IList<Material> MaterialList { get; set; } = new List<Material>();

                        /// <summary>
                        /// 获取或设置抖音授权信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("douyin_auth_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("douyin_auth_info")]
                        public IList<Types.DouyinAuthInfo>? DouyinAuthInfoList { get; set; }
                    }

                    public class InstitutionQualification
                    {
                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置简介。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_introduction")]
                        public string Introduction { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置公司名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                        public string CompanyIntroduction { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_record_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_record_name")]
                        public string InstitutionRecordName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构场景类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_scene_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_scene_type")]
                        public string InstitutionSceneType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构主体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_subject_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_subject_type")]
                        public string InstitutionSubjectType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置法人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person_name")]
                        public string LegalPersonName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置法人身份证号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person_ID_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person_ID_number")]
                        public string LegalPersonIdCardNumber { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置法人身份证照片资源路径列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person_ID_img_uris")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person_ID_img_uris")]
                        public IList<string> LegalPersonIdCardImagePathList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置照片资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("img_uri")]
                        public string? ImagePath { get; set; }

                        /// <summary>
                        /// 获取或设置 Logo 资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_logo_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_logo_uri")]
                        public string? LogoPath { get; set; }

                        /// <summary>
                        /// 获取或设置商标资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("institution_trade_mark_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("institution_trade_mark_uri")]
                        public string? TradeMarkPath { get; set; }

                        /// <summary>
                        /// 获取或设置昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_info_lst")]
                        public IList<Material> MaterialList { get; set; } = new List<Material>();
                    }

                    public class Material
                    {
                        /// <summary>
                        /// 获取或设置材料类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置材料照片资源路径列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_uris")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_uris")]
                        public IList<string> ImagePathList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置材料有效期字符串（格式：yyyy-MM-dd / "长期有效"）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("validity_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("validity_date")]
                        public string ValidityDateString { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置证书编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("license_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("license_id")]
                        public string? LicenseId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审核主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("object_type")]
                [System.Text.Json.Serialization.JsonPropertyName("object_type")]
                public int ObjectType { get; set; }

                /// <summary>
                /// 获取或设置教师资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("teacher_qualification_info")]
                [System.Text.Json.Serialization.JsonPropertyName("teacher_qualification_info")]
                public Types.TeacherQualification? TeacherQualification { get; set; }

                /// <summary>
                /// 获取或设置机构资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("institution_qualification_info")]
                [System.Text.Json.Serialization.JsonPropertyName("institution_qualification_info")]
                public Types.InstitutionQualification? InstitutionQualification { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置资质信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification")]
        public Types.Qualification Qualification { get; set; } = new Types.Qualification();
    }
}
