namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_basic_auth 接口的请求。</para>
    /// </summary>
    public class AuthEntityGetBasicAuthRequest: ByteDanceMicroAppRoleApiRequest
    {
        /// <summary>
        /// 获取或设置实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;
    }
}
