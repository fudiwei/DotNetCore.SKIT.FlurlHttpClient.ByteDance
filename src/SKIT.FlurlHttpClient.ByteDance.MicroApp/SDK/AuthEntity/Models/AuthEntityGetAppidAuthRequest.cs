namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
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
}
