namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query_entity_info 接口的响应。</para>
    /// </summary>
    public class AuthEntityQueryEntityInfoResponse : ByteDanceMicroAppRoleApiResponse
    {
        /// <summary>
        /// 获取或设置实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = default!;
    }
}
