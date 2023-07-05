namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetClassAuthRequest : ByteDanceMicroAppAuthEntityRequest
    {
        public static class Types
        {
            public class IndustryClass
            {
                /// <summary>
                /// 1 级行业类目
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_class")]
                [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                public int FirstClass { get; set; }

                /// <summary>
                /// 2 级行业类目
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_class")]
                [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                public int SecondClass { get; set; }

                /// <summary>
                /// 3 级行业类目
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_class")]
                [System.Text.Json.Serialization.JsonPropertyName("third_class")]
                public int ThirdClass { get; set; }
            }

        }
        /// <summary>
        /// 服务商实体ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("partner_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("partner_entity_id")]
        public string? PartnerEntityId { get; set; }

        /// <summary>
        /// 机构添加类目认证时必填；老师角色实体必填
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_entity_id")]
        public string? MerchantEntityId { get; set; }
        /// <summary>
        /// 行业code，10000:泛知识
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_code")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_code")]
        public int IndustryCode { get; set; }
        /// <summary>
        /// 行业类目信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_class")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_class")]
        public Types.IndustryClass? IndustryClass { get; set; }
        /// <summary>
        /// 1：老师 2：机构 3：服务商
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry_role")]
        [System.Text.Json.Serialization.JsonPropertyName("industry_role")]
        public int IndustryRole { get; set; }

    }
}
