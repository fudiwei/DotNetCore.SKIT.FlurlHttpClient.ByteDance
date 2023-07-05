using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityRoleBindOrUnRequest : ByteDanceMicroAppAuthEntityRequest
    {
        /// <summary>
        /// 要绑定小程序的实体。（仅机构or服务商）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_entity_id")]
        public string MerchantEntityId { get; set; }

        /// <summary>
        /// 行业编码，泛知识10000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public string IndustryCode { get; set; }

        /// <summary>
        /// 实体角色类型（1：老师 2：机构 3：服务商）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_industry_role")]
        public string MerchantIndustryRole { get; set; }

    }

    public class AuthEntityRoleBindOrUnResponse : ByteDanceMicroAppAuthEntityResponse
    {

    }

    public class AuthEntityGetBindListRequest : ByteDanceMicroAppAuthEntityRequest
    {

    }
    public class AuthEntityGetBindListResponse : ByteDanceMicroAppAuthEntityResponse
    {
        public static class Types
        {
            public class BindInfo
            {
                /// <summary>
                /// 小程序appid
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; }

                /// <summary>
                /// 角色id
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role_id")]
                [System.Text.Json.Serialization.JsonPropertyName("role_id")]
                public string RoleId { get; set; }

                /// <summary>
                /// 1:个人(泛知识行业为老师),2:自营机构,3:服务商
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_role")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
                public int IndustryRole { get; set; }

                /// <summary>
                /// 1000:泛知识
                /// </summary>
                [Newtonsoft.Json.JsonProperty("industry_code")]
                [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
                public long IndustryCode { get; set; }

            }
        }
        /// <summary>
        /// 小程序绑定的所有角色
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_info_list")]
        public List<Types.BindInfo> BindInfoList { get; set; }
    }

    public class AuthEntityGetAppidAuthRequest : ByteDanceMicroAppAuthEntityRequest
    {
        /// <summary>
        /// 服务商实体ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_entity_id")]
        public string PartnerEntityId { get; set; } = string.Empty;

        /// <summary>
        /// 被授权实体
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_entity_id")]
        public string MerchantEntityId { get; set; } = string.Empty;

        /// <summary>
        /// 授权实体角色类型（1：老师 2：机构 ）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_industry_role")]
        public int MerchantIndustryRole { get; set; }
    }

    public class AuthEntityGetAppidAuthResponse : ByteDanceMicroAppAuthEntityResponse
    {
        public static class Types
        {
            public class Qualification
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

            public class AuthLetter
            {
                /// <summary>
                /// 资质材料类型，目前支持的类型见上传资料接口
                /// <see href="https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/pan-knowledge/role/upload-qualification-materials"/>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_taskid")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_taskid")]
                public string AuditTaskid { get; set; } = string.Empty;

                /// <summary>
                /// 资质审核状态 1：审核中 2：审核成功 3：审核失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                public int AuditStatus { get; set; }

                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string AuditReason { get; set; } = string.Empty;

                /// <summary>
                /// 资料过期时间，示例：2029-09-10
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                public string ExpireTime { get; set; } = string.Empty;

                /// <summary>
                /// 资质材料
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualifications")]
                [System.Text.Json.Serialization.JsonPropertyName("qualifications")]
                public List<Types.Qualification>? Qualifications { get; set; }
            }
            public class Data
            {
                /// <summary>
                /// 线上版资质信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = string.Empty;

                [Newtonsoft.Json.JsonProperty("online_auth_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("online_auth_letter")]
                public Types.AuthLetter? OnlineAuthLetter { get; set; }

                [Newtonsoft.Json.JsonProperty("audit_auth_letter")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_auth_letter")]
                public Types.AuthLetter? AuditAuthLetter { get; set; }

                /// <summary>
                /// 商家在小程序下的权限，按位处理 1：可以支付/收款 2：可以上传课程库
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public int Scope { get; set; }

                /// <summary>
                /// 老师或机构在小程序内昵称 2<=len<=30 (中文占2个字符)
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nick")]
                [System.Text.Json.Serialization.JsonPropertyName("nick")]
                public string Nick { get; set; } = string.Empty;

                /// <summary>
                /// 老师或机构在小程序内头像（需要使用上传资质材料接口）
                /// </summary>
                [Newtonsoft.Json.JsonProperty("icon")]
                [System.Text.Json.Serialization.JsonPropertyName("icon")]
                public string Icon { get; set; } = string.Empty;

                /// <summary>
                /// 老师或机构在小程序描述 1<=len<=2000 (中文占2个字符)
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string Desc { get; set; } = string.Empty;

                /// <summary>
                /// 认证状态 1:审核中 2:认证成功 3:认证失败
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_status")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
                public int AuthStatus { get; set; }

                /// <summary>
                /// 认证原因
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_reason")]
                public string AuthReason { get; set; } = string.Empty;

            }
        }

        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
