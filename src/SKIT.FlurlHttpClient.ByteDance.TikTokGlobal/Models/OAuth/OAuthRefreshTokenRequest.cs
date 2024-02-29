namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/refresh_token/ 接口的请求。</para>
    /// </summary>
    public class OAuthRefreshTokenRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置 TikTok ClientKey。如果不指定将使用构造 <see cref="TikTokV2Client"/> 时的 <see cref="TikTokV2ClientOptions.ClientKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置 TikTok ClientSecret。如果不指定将使用构造 <see cref="TikTokV2Client"/> 时的 <see cref="TikTokV2ClientOptions.ClientSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 获取或设置刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
