namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.RoleApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /get_basic_auth 接口的请求。</para>
    /// </summary>
    public class AuthEntityGetBasicAuthRequest: DouyinMicroAppRoleApiRequest
    {
        /// <summary>
        /// 获取或设置实体 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        public string EntityId { get; set; } = string.Empty;
    }
}
