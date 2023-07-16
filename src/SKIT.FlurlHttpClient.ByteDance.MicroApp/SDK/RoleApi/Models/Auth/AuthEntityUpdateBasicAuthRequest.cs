using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /update_basic_auth 接口的请求。</para>
    /// </summary>
    public class AuthEntityUpdateBasicAuthRequest : ByteDanceMicroAppRoleApiRequest
    {
        public static class Types
        {
            public class Material : AuthEntityByPartnerRequest.Types.Material
            {
            }

            public class Person : AuthEntityByPartnerRequest.Types.Person
            {
            }

            public class Enterprise
            {
                /// <summary>
                /// 获取或设置营业执照编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_id")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                public string CertificateId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置资质材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_materials")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_materials")]
                public IList<Material>? CertificateMaterialList { get; set; }

                /// <summary>
                /// 获取或设置法人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person")]
                public Person? LegalPerson { get; set; }
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
        /// 获取或设置实体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_name")]
        public string EntityName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置个人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual")]
        [System.Text.Json.Serialization.JsonPropertyName("individual")]
        public Types.Person? Individual { get; set; }

        /// <summary>
        /// 获取或设置企业信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enterprise")]
        [System.Text.Json.Serialization.JsonPropertyName("enterprise")]
        public Types.Enterprise? Enterprise { get; set; } 
    }
}
