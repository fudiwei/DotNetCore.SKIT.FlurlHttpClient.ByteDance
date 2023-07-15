using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityGetBasicAuthRequest: ByteDanceMicroAppAuthEntityRequest
    {
        /// <summary>
        /// 实体id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;
    }
}
