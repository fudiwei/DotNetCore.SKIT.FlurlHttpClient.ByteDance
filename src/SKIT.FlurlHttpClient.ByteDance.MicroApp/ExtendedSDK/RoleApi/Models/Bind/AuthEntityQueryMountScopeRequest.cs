namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_mountscope 接口的请求。</para>
    /// </summary>
    public class AuthEntityQueryMountScopeRequest : DouyinMicroAppRoleApiRequest
    {
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
        /// 获取或设置用户的 OpenId。与字段 <see cref="AwemeId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户的抖音号。与字段 <see cref="OpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string? AwemeId { get; set; }

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
