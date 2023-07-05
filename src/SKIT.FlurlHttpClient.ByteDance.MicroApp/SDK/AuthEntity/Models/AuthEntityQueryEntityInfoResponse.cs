namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.AuthEntity.Models
{
    public class AuthEntityQueryEntityInfoResponse : ByteDanceMicroAppAuthEntityResponse
    {

        /// <summary>
        /// 角色系统的实体ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;

    }
}
