namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/renew_refresh_token 接口的请求。</para>
    /// </summary>
    public class OAuthRenewRefreshTokenRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置抖音开放平台应用 Key。如果不指定将使用构造 <see cref="TikTokClient"/> 时的 <see cref="TikTokClientOptions.ClientKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
