namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/check_qrcode/ 接口的请求。</para>
    /// </summary>
    public class OAuthCheckQrcodeRequest : TikTokV2Request
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
        /// 获取或设置二维码令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;
    }
}
