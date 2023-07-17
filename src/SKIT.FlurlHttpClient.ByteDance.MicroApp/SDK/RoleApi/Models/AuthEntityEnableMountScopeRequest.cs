using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /enable_mountscope 接口的请求。</para>
    /// </summary>
    public class AuthEntityEnableMountScopeRequest : ByteDanceMicroAppRoleApiRequest
    {
        public static class Types
        {
            public class User
            {
                /// <summary>
                /// 获取或设置开放平台 ClientKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("client_key")]
                [System.Text.Json.Serialization.JsonPropertyName("client_key")]
                public string ClientKey { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = string.Empty;
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
        /// 获取或设置挂载能力。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mount_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("mount_scope")]
        public int MountScope { get; set; }

        /// <summary>
        /// 获取或设置抖音用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("c_user")]
        [System.Text.Json.Serialization.JsonPropertyName("c_user")]
        public Types.User User { get; set; } = new Types.User();

        /// <summary>
        /// 获取或设置行业编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public int IndustryCode { get; set; }

        /// <summary>
        /// 获取或设置行业角色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
        public int IndustryRole { get; set; }
    }
}
