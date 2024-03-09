using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /update_class_auth 接口的请求。</para>
    /// </summary>
    public class AuthEntityUpdateClassAuthRequest : DouyinMicroAppRoleApiRequest
    {
        public static class Types
        {
            public class Material : AuthEntityByPartnerRequest.Types.Material
            {
            }

            public class Person : AuthEntityByPartnerRequest.Types.Person
            {
            }

            public class IndustryClass : AuthEntityByPartnerRequest.Types.ClassAuth.Types.IndustryClass
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

            public class Partner
            {
                /// <summary>
                /// 获取或设置服务商类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_type")]
                [System.Text.Json.Serialization.JsonPropertyName("company_type")]
                public string CompanyType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置公司地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("company_addr")]
                public string CompanyAddress { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置合作案例列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_cases")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_cases")]
                public IList<Material>? CooperationCaseList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_entity_id")]
        public string? PartnerEntityId { get; set; }

        /// <summary>
        /// 获取或设置商户实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_entity_id")]
        public string? MerchantEntityId { get; set; }

        /// <summary>
        /// 获取或设置行业编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public int IndustryCode { get; set; }

        /// <summary>
        /// 获取或设置行业类目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class")]
        [System.Text.Json.Serialization.JsonPropertyName("class")]
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
        [Newtonsoft.Json.JsonProperty("merchant_qualifications")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_qualifications")]
        public List<Types.Material>? QualificationMaterialList { get; set; }

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
    }
}
