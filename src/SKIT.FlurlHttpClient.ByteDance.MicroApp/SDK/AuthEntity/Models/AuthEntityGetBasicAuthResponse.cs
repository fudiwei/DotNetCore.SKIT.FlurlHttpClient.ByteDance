using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetBasicAuthResponse: ByteDanceMicroAppAuthEntityResponse
    {
        public static class Types
        {
            public class Individual
            {
                /// <summary>
                /// 个人姓名，需要和身份证一致，字符长度限制 2 <= len(name) <=30（汉字占2字符）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; }
                /// <summary>
                /// 身份证号码
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_number")]
                public string IdNumber { get; set; }
                /// <summary>
                /// 身份证有效期
                /// <example>长期有效；2034-01-09</example>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTime { get; set; }
                /// <summary>
                /// 身份证正面链接,人像面
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_path")]
                [System.Text.Json.Serialization.JsonPropertyName("front_path")]
                public string FrontPath { get; set; }
                /// <summary>
                /// 身份反面链接,国徽面
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_path")]
                [System.Text.Json.Serialization.JsonPropertyName("back_path")]
                public string BackPath { get; set; }
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
                public int MaterialExpiretime { get; set; }

                /// <summary>
                /// 资质材料链接，字符串数组
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_paths")]
                [System.Text.Json.Serialization.JsonPropertyName("material_paths")]
                public List<string> MaterialPaths { get; set; }
            }

            public class Enterprise
            {
                /// <summary>
                /// 营业执照编号
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                public string CertificateId { get; set; }

                /// <summary>
                /// 资质材料信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_materials")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_materials")]
                public List<CertificateMaterial> CertificateMaterials { get; set; }
                /// <summary>
                /// 法人信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public Individual LegalPerson { get; set; }
            }

            /// <summary>
            /// 实体基础认证信息
            /// </summary>
            public class BasicAuth
            {
                /// <summary>
                /// 实体类型 1: 个人 2:企业
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_type")]
                public int EntityType { get; set; }
                /// <summary>
                /// 实体名称
                /// 实体类型为1，该字段为个人姓名，字符长度限制
                /// 2 <= len(name) <=30（汉字占2字符）
                /// 实体类型为2，该字段为企业名称，字符长度限制4<=len<= 40(汉字占 2 字符)应当与营业执照上主体名称一致
                /// </summary>
                [Newtonsoft.Json.JsonProperty("entity_name")]
                [System.Text.Json.Serialization.JsonPropertyName("entity_name")]
                public int EntityName { get; set; }
                /// <summary>
                /// 证件照类型 1：身份证 2：营业执照
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_type")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_type")]
                public int CertificateType { get; set; }

                /// <summary>
                /// 实体类型为个人，参数必填
                /// </summary>
                [Newtonsoft.Json.JsonProperty("individual")]
                [System.Text.Json.Serialization.JsonPropertyName("individual")]
                public Individual? Individual { get; set; }

                /// <summary>
                /// 实体类型为企业，参数必填
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enterprise")]
                [System.Text.Json.Serialization.JsonPropertyName("enterprise")]
                public Enterprise? Enterprise { get; set; }
            }

            public class Employee
            {
                /// <summary>
                /// 机构员工个人身份信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("employee_material")]
                [System.Text.Json.Serialization.JsonPropertyName("employee_material")]
                public Individual EmployeeMaterial { get; set; }

                /// <summary>
                /// 机构和员工合作协议
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cooperation_agreement")]
                [System.Text.Json.Serialization.JsonPropertyName("cooperation_agreement")]
                public CertificateMaterial? CooperationAgreement { get; set; }
            }
            public class Institution
            {
                /// <summary>
                /// 机构备案名称,需要与营业执照名称一致或有名称关键词，字符长度限制4<=len<= 40(汉字占 2 字符)
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_name")]
                [System.Text.Json.Serialization.JsonPropertyName("record_name")]
                public string RecordName { get; set; }

                /// <summary>
                /// 机构场景类型（仅可填写"线上机构"或"线下机构"）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_type")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
                public string SceneType { get; set; }

                /// <summary>
                /// 机构主体类型（仅可填"企业工商户"或"个体工商户"）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subject_type")]
                [System.Text.Json.Serialization.JsonPropertyName("subject_type")]
                public string SubjectType { get; set; }

                /// <summary>
                /// 机构Logo图片uri，需要调用上传资源接口后获得
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
                public string LogoUri { get; set; }

                /// <summary>
                /// 商标注册证图片uri，若机构名称与机构logo一致性差，则需提供，需要调用上传后获得
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trademark_uri")]
                [System.Text.Json.Serialization.JsonPropertyName("trademark_uri")]
                public string TrademarkUri { get; set; }

                /// <summary>
                /// 机构介绍，字符长度限制12<=len<= 200(汉字占 2 字符)
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Desc { get; set; }

                /// <summary>
                /// 机构合作老师信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("employee")]
                [System.Text.Json.Serialization.JsonPropertyName("employee")]
                public Employee Employee { get; set; }
            }

            public class AllQualification
            {
                /// <summary>
                /// 资质审核任务ID
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_taskid")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
                public int AuditTaskid { get; set; }

                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public string AuditStatus { get; set; }

                /// <summary>
                /// 资质材料
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public List<CertificateMaterial> Qualifications { get; set; }

                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string AuditReason { get; set; }
                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public DateTime ExpireTime { get; set; }
            }
        }
        /// <summary>
        /// 实体基础认证信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basic_auth")]
        [System.Text.Json.Serialization.JsonPropertyName("basic_auth")]
        public Types.BasicAuth? BasicAuth { get; set; }

        /// <summary>
        /// 认证状态 1：认证中 2：认证成功 3:认证失败
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_status")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
        public int AuthStatus { get; set; }

        /// <summary>
        /// 认证原因
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_reason")]
        public string? AuthReason { get; set; }

        /// <summary>
        /// 线上生效的资质信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("online_qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("online_qualification")]
        public Types.AllQualification? OnlineQualification { get; set; }

        /// <summary>
        /// 最近审核中的资质信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_qualification")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_qualification")]
        public Types.AllQualification? AuditQualification { get; set; }
        

    }
}
