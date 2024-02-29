namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/token/ 接口的请求。</para>
    /// </summary>
    public class OAuthAccessTokenRequest : TikTokV2Request
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
        public string GrantType { get; set; } = "authorization_code";

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置重定向 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_uri")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// 获取或设置授权码验证器。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code_verifier")]
        [System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }
    }
}
