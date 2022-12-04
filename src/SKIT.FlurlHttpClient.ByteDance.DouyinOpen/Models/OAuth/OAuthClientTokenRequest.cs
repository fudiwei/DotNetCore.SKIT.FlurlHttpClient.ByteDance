namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/client_token 接口的请求。</para>
    /// </summary>
    public class OAuthClientTokenRequest : DouyinOpenRequest
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
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "client_credential";
    }
}
