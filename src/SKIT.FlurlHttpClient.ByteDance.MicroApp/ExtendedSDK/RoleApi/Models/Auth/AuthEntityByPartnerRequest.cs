using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /bypartner 接口的请求。</para>
    /// </summary>
    public class AuthEntityByPartnerRequest : DouyinMicroAppRoleApiRequest
    {
        public static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置资质材料类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_type")]
                [System.Text.Json.Serialization.JsonPropertyName("material_type")]
                public int MaterialType { get; set; }

                /// <summary>
                /// 获取或设置资料过期时间字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_expiretime")]
                [System.Text.Json.Serialization.JsonPropertyName("material_expiretime")]
                public string MaterialExpireTime { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置资质材料资源路径列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_paths")]
                [System.Text.Json.Serialization.JsonPropertyName("material_paths")]
                public IList<string>? MaterialPaths { get; set; }
            }

            public class Person
            {
                /// <summary>
                /// 获取或设置个人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_number")]
                public string IdNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证有效期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTimeString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证正面资源文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_path")]
                [System.Text.Json.Serialization.JsonPropertyName("front_path")]
                public string FrontMaterialPath { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证背面资源文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_path")]
                [System.Text.Json.Serialization.JsonPropertyName("back_path")]
                public string BackMaterialPath { get; set; } = string.Empty;
            }

            public class BasicAuth
            {
                public static class Types
                {
                    public class Enterprise
                    {
                        /// <summary>
                        /// 获取或设置营业执照编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置资质材料列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_materials")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_materials")]
                        public IList<Material>? CertificateMaterialList { get; set; }

                        /// <summary>
                        /// 获取或设置法人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("legal_person")]
                        [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                        public Person? LegalPerson { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置实体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_type")]
                public int EntityType { get; set; }

                /// <summary>
                /// 获取或设置实体名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_name")]
                public string EntityName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件照类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_type")]
                public int CertificateType { get; set; }

                /// <summary>
                /// 获取或设置个人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("individual")]
                [System.Text.Json.Serialization.JsonPropertyName("individual")]
                public Person? Individual { get; set; }

                /// <summary>
                /// 获取或设置企业信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enterprise")]
                [System.Text.Json.Serialization.JsonPropertyName("enterprise")]
                public Types.Enterprise? Enterprise { get; set; }
            }

            public class ClassAuth
            {
                public static class Types
                {
                    public class IndustryClass
                    {
                        /// <summary>
                        /// 获取或设置一级行业类目。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                        public int FirstClass { get; set; }

                        /// <summary>
                        /// 获取或设置二级行业类目。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                        public int SecondClass { get; set; }

                        /// <summary>
                        /// 获取或设置三级行业类目。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                        public int ThirdClass { get; set; }
                    }

                    public class Employee
                    {
                        /// <summary>
                        /// 获取或设置机构员工个人身份信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("employee_material")]
                        [System.Text.Json.Serialization.JsonPropertyName("employee_material")]
                        public Person? EmployeeMaterial { get; set; }

                        /// <summary>
                        /// 获取或设置机构和员工合作协议信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cooperation_agreement")]
                        [System.Text.Json.Serialization.JsonPropertyName("cooperation_agreement")]
                        public Material? CooperationAgreement { get; set; }
                    }

                    public class Institution
                    {
                        /// <summary>
                        /// 获取或设置机构备案名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("record_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("record_name")]
                        public string RecordName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构场景类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
                        public string SceneType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构主体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subject_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                        public string SubjectType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构 Logo 图片资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logo_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
                        public string? LogoPath { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册证图片资源路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_uri")]
                        public string? TrademarkPath { get; set; }

                        /// <summary>
                        /// 获取或设置机构介绍。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置机构合作老师信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("employee")]
                        [System.Text.Json.Serialization.JsonPropertyName("employee")]
                        public Employee? Employee { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置行业编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_code")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                public int IndustryCode { get; set; }

                /// <summary>
                /// 获取或设置行业类目信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_class")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_class")]
                public Types.IndustryClass IndustryClass { get; set; } = new Types.IndustryClass();

                /// <summary>
                /// 获取或设置行业角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_role")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
                public int IndustryRole { get; set; }

                /// <summary>
                /// 获取或设置资质材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public List<Material>? QualificationMaterialList { get; set; }

                /// <summary>
                /// 获取或设置机构信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("institution")]
                [System.Text.Json.Serialization.JsonPropertyName("institution")]
                public Types.Institution? Institution { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置实体基础认证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth")]
        public Types.BasicAuth BasicAuth { get; set; } = new Types.BasicAuth();

        /// <summary>
        /// 获取或设置实体类目认证信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auth")]
        public Types.ClassAuth ClassAuth { get; set; } = new Types.ClassAuth();
    }
}
