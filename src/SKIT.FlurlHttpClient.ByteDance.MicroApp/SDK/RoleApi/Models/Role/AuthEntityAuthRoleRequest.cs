using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /auth_role 接口的请求。</para>
    /// </summary>
    public class AuthEntityAuthRoleRequest : ByteDanceMicroAppRoleApiRequest
    {
        public static class Types
        {
            public class Material : AuthEntityByPartnerRequest.Types.Material
            {
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
        /// 获取或设置授权函材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_letters")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_letters")]
        public List<Types.Material>? AuthLetterMaterialList { get; set; }

        /// <summary>
        /// 获取或设置权限类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public int? Scope { get; set; }

        /// <summary>
        /// 获取或设置昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nick")]
        [System.Text.Json.Serialization.JsonPropertyName("nick")]
        public string Nickname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置头像资源路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon")]
        [System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string IconPath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("desc")]
        [System.Text.Json.Serialization.JsonPropertyName("desc")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置角色类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_industry_role")]
        public int IndustryRole { get; set; }
    }
}
