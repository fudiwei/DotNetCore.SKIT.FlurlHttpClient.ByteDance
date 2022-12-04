namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/refresh_token 接口的请求。</para>
    /// </summary>
    public class OAuthRefreshTokenRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置抖音开放平台应用 Key。如果不指定将使用构造 <see cref="DouyinOpenClient"/> 时的 <see cref="DouyinOpenClientOptions.ClientKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置抖音开放平台应用密钥。如果不指定将使用构造 <see cref="DouyinOpenClient"/> 时的 <see cref="DouyinOpenClientOptions.ClientSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 获取或设置刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
