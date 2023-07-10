using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityUpdateBasicAuthRequest : ByteDanceMicroAppAuthEntityRequest
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
            public class Enterprise
            {
                /// <summary>
                /// 营业执照编号
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                public string CertificateId { get; set; } = string.Empty;

                /// <summary>
                /// 资质材料信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_materials")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_materials")]
                public List<CertificateMaterial>? CertificateMaterials { get; set; }
                /// <summary>
                /// 法人信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public Individual? LegalPerson { get; set; }
            }
        }

        /// <summary>
        /// 服务商实体ID ，服务商更新自己实体基础认证时必填，服务商帮助老师/代运营模式机构更新基础认证信息时必填
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_entity_id")]
        public string? PartnerEntityId { get; set; }

        /// <summary>
        /// 机构更新实体基础认证时必填；老师角色实体必填
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_entity_id")]
        public string MerchantEntityId { get; set; } = string.Empty;

        /// <summary>
        /// 实体名称
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_name")]
        public string EntityName { get; set; } = string.Empty;

        /// <summary>
        /// 个人实体基础认证信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual")]
        [System.Text.Json.Serialization.JsonPropertyName("individual")]
        public Types.Individual? Individual { get; set; }

        /// <summary>
        /// 企业实体基础认证信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enterprise")]
        [System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public Types.Enterprise? Enterprise { get; set; }

    }
}
