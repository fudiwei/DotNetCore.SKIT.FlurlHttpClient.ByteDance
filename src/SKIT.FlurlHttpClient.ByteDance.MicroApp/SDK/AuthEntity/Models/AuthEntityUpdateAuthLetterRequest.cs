using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityUpdateAuthLetterRequest : ByteDanceMicroAppAuthEntityRequest
    {
        public static class Types
        {
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
        }

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
        /// 行业编码，泛知识10000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public int IndustryCode { get; set; }

        /// <summary>
        /// 授权函
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_letters")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_letters")]
        public List<Types.CertificateMaterial>? AuthLetters { get; set; }

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
        /// 授权实体角色类型（1：老师 2：机构 3：服务商）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_industry_role")]
        public int MerchantIndustryRole { get; set; }

    }
}
