namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth2/refresh_token 接口的请求。</para>
    /// </summary>
    public class OAuth2RefreshTokenRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="OceanEngineClient"/> 时的 <see cref="OceanEngineClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public long? AppId { get; set; }

        /// <summary>
        /// 获取或设置应用密钥。如果不指定将使用构造 <see cref="OceanEngineClient"/> 时的 <see cref="OceanEngineClientOptions.AppSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("secret")]
        [System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? AppSecret { get; set; }

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 获取或设置接口刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
