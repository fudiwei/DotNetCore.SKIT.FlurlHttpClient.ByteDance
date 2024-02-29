namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/get_qrcode/ 接口的请求。</para>
    /// </summary>
    public class OAuthGetQrcodeRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置 TikTok 应用 Key。如果不指定将使用构造 <see cref="TikTokV2Client"/> 时的 <see cref="TikTokV2ClientOptions.ClientKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置授权范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string Scope { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义状态值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }
    }
}
