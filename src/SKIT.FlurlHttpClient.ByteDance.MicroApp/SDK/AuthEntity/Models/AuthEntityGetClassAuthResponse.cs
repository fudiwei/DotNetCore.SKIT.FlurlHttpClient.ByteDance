using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetClassAuthResponse : ByteDanceMicroAppAuthEntityResponse
    {
        public static class Types
        {

            public class ClassAuth
            {
                /// <summary>
                /// 行业code
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_code")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                public int IndustryCode { get; set; }
                /// <summary>
                /// 行业类目信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_class")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_class")]
                public IndustryClass? IndustryClass { get; set; }

                /// <summary>
                /// 1：老师 2：机构 3：服务商
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_role")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
                public int IndustryRole { get; set; }


                /// <summary>
                /// 机构角色必填信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("institution")]
                [System.Text.Json.Serialization.JsonPropertyName("institution")]
                public Institution? Institution { get; set; }



                /// <summary>
                /// 服务商角色必填信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partner")]
                [System.Text.Json.Serialization.JsonPropertyName("partner")]
                public Partner? Partner { get; set; }

                /// <summary>
                /// 线上生效的资质相关信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("online_qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("online_qualification")]
                public AuditQualification? OnlineQualification { get; set; }

                /// <summary>
                /// 当前审核的的资质信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_qualification")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_qualification")]
                public AuditQualification? AuditQualification { get; set; }




            }

            public class IndustryClass
            {
                /// <summary>
                /// 1 级行业类目
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_class")]
                [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                public int FirstClass { get; set; }

                /// <summary>
                /// 2 级行业类目
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_class")]
                [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                public int SecondClass { get; set; }

                /// <summary>
                /// 3 级行业类目
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_class")]
                [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                public int ThirdClass { get; set; }
            }

            public class Institution
            {
                /// <summary>
                /// 机构备案名称,需要与营业执照名称一致或有名称关键词，字符长度限制4<=len<= 40(汉字占 2 字符)
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_name")]
                [System.Text.Json.Serialization.JsonPropertyName("record_name")]
                public string RecordName { get; set; } = string.Empty;

                /// <summary>
                /// 机构场景类型（仅可填写"线上机构"或"线下机构"）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_type")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
                public string SceneType { get; set; } = string.Empty;

                /// <summary>
                /// 机构主体类型（仅可填"企业工商户"或"个体工商户"）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_type")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                public string SubjectType { get; set; } = string.Empty;

                /// <summary>
                /// 机构Logo图片uri，需要调用上传资源接口后获得
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
                public string LogoUri { get; set; } = string.Empty;

                /// <summary>
                /// 商标注册证图片uri，若机构名称与机构logo一致性差，则需提供，需要调用上传后获得
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trademark_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("trademark_uri")]
                public string TrademarkUri { get; set; } = string.Empty;

                /// <summary>
                /// 机构介绍，字符长度限制12<=len<= 200(汉字占 2 字符)
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Desc { get; set; } = string.Empty;

                /// <summary>
                /// 机构合作老师信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("employee")]
                [System.Text.Json.Serialization.JsonPropertyName("employee")]
                public Employee? Employee { get; set; }
            }

            public class Employee
            {
                /// <summary>
                /// 机构员工个人身份信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("employee_material")]
                [System.Text.Json.Serialization.JsonPropertyName("employee_material")]
                public Individual? EmployeeMaterial { get; set; }

                /// <summary>
                /// 机构和员工合作协议
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_agreement")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_agreement")]
                public CertificateMaterial? CooperationAgreement { get; set; }
            }

            public class Individual
            {
                /// <summary>
                /// 个人姓名，需要和身份证一致，字符长度限制 2 <= len(name) <=30（汉字占2字符）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;
                /// <summary>
                /// 身份证号码
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_number")]
                public string IdNumber { get; set; } = string.Empty;
                /// <summary>
                /// 身份证有效期
                /// <example>长期有效；2034-01-09</example>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTime { get; set; } = string.Empty;
                /// <summary>
                /// 身份证正面链接,人像面
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_path")]
                [System.Text.Json.Serialization.JsonPropertyName("front_path")]
                public string FrontPath { get; set; } = string.Empty;
                /// <summary>
                /// 身份反面链接,国徽面
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_path")]
                [System.Text.Json.Serialization.JsonPropertyName("back_path")]
                public string BackPath { get; set; } = string.Empty;
            }

            public class CertificateMaterial
            {
                /// <summary>
                /// 资质材料类型，目前支持的类型见上传资料接口
                /// <see href="https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/upload-qualification-materials"/>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_type")]
                [System.Text.Json.Serialization.JsonPropertyName("material_type")]
                public int MaterialType { get; set; }

                /// <summary>
                /// 资料过期时间，示例：2029-09-10
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_expiretime")]
                [System.Text.Json.Serialization.JsonPropertyName("material_expiretime")]
                public string MaterialExpireTime { get; set; } = string.Empty;

                /// <summary>
                /// 资质材料链接，字符串数组
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_paths")]
                [System.Text.Json.Serialization.JsonPropertyName("material_paths")]
                public List<string>? MaterialPaths { get; set; }
            }

            public class Partner
            {
                /// <summary>
                /// 企业工商户/个体工商户
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_type")]
                [System.Text.Json.Serialization.JsonPropertyName("company_type")]
                public string CompanyType { get; set; } = string.Empty;

                /// <summary>
                /// 企业工商户/个体工商户
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_addr")]
                [System.Text.Json.Serialization.JsonPropertyName("company_addr")]
                public string CompanyAddr { get; set; } = string.Empty;

                /// <summary>
                /// 资质材料链接，字符串数组。 合作案例资料图片。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_cases")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_cases")]
                public List<CertificateMaterial>? CooperationCases { get; set; }
            }

            public class AuditQualification
            {
                /// <summary>
                /// 资质审核任务ID
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_taskid")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
                public string AuditTaskId { get; set; } = string.Empty;
                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int AuditStatus { get; set; }
                /// <summary>
                /// 审核失败时原因
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string AuditReason { get; set; } = string.Empty;
                /// <summary>
                /// 资质材料中最大的过期时间，示例：2022-10-10
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTime { get; set; } = string.Empty;

                /// <summary>
                /// 资质材料
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public List<CertificateMaterial>? Qualifications { get; set; }
            }
        }


        [Newtonsoft.Json.JsonProperty("class_auths")]
        [System.Text.Json.Serialization.JsonPropertyName("class_auths")]
        public List<Types.ClassAuth>? ClassAuths { get; set; }


    }
}
