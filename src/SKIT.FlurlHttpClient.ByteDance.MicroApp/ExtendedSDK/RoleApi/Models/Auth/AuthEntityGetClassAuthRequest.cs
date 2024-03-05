namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_class_auth 接口的请求。</para>
    /// </summary>
    public class AuthEntityGetClassAuthRequest : DouyinMicroAppRoleApiRequest
    {
        public static class Types
        {
            public class IndustryClass : AuthEntityByPartnerRequest.Types.ClassAuth.Types.IndustryClass
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
        public int? IndustryCode { get; set; }

        /// <summary>
        /// 获取或设置行业类目信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_class")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_class")]
        public Types.IndustryClass? IndustryClass { get; set; }

        /// <summary>
        /// 获取或设置行业角色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
        public int? IndustryRole { get; set; }
    }
}
