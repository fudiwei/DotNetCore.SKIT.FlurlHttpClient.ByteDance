using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_class_auth 接口的响应。</para>
    /// </summary>
    public class AuthEntityGetClassAuthResponse : ByteDanceMicroAppRoleApiResponse
    {
        public static class Types
        {
            public class Material : AuthEntityGetBasicAuthResponse.Types.Material
            {
            }

            public class Person : AuthEntityGetBasicAuthResponse.Types.Person
            {
            }

            public class ClassAuth
            {
                public static class Types
                {
                    public class IndustryClass : AuthEntityGetClassAuthRequest.Types.IndustryClass
                    {
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
                        public string RecordName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机构场景类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scene_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
                        public string SceneType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机构主体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subject_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                        public string SubjectType { get; set; } = default!;

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
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置机构合作老师信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("employee")]
                        [System.Text.Json.Serialization.JsonPropertyName("employee")]
                        public Employee? Employee { get; set; }
                    }

                    public class Partner
                    {
                        /// <summary>
                        /// 获取或设置服务商类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_type")]
                        public string CompanyType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置公司地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("company_addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("company_addr")]
                        public string CompanyAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置合作案例列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cooperation_cases")]
                        [System.Text.Json.Serialization.JsonPropertyName("cooperation_cases")]
                        public IList<Material>? CooperationCaseList { get; set; }
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
                public Types.IndustryClass IndustryClass { get; set; } = default!;

                /// <summary>
                /// 获取或设置行业角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_role")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
                public int IndustryRole { get; set; }

                /// <summary>
                /// 获取或设置资质信息列表。
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

                /// <summary>
                /// 获取或设置服务商信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partner")]
                [System.Text.Json.Serialization.JsonPropertyName("partner")]
                public Types.Partner? Partner { get; set; }

                /// <summary>
                /// 获取或设置线上生效的资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("online_qualification")]
                public Qualification? OnlineQualification { get; set; }

                /// <summary>
                /// 获取或设置最近审核中的资质信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_qualification")]
                public Qualification? AuditQualification { get; set; }
            }

            public class Qualification : AuthEntityGetBasicAuthResponse.Types.Qualification
            {
            }
        }

        /// <summary>
        /// 获取或设置类目认证信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_auths")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auths")]
        public Types.ClassAuth[] ClassAuthList { get; set; } = default!;
    }
}
