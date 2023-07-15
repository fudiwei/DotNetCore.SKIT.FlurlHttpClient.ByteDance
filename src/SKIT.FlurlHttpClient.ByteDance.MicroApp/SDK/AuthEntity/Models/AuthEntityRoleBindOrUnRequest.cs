using System;
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
        public string MerchantEntityId { get; set; } = string.Empty;

        /// <summary>
        /// 行业编码，泛知识10000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public string IndustryCode { get; set; } = string.Empty;

        /// <summary>
        /// 实体角色类型（1：老师 2：机构 3：服务商）
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_industry_role")]
        public string MerchantIndustryRole { get; set; }  = string.Empty;

    }
}
