namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/business_token/ 接口的请求。</para>
    /// </summary>
    public class OAuthBusinessTokenRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置抖音开放平台 ClientKey。如果不指定将使用构造 <see cref="DouyinOpenClient"/> 时的 <see cref="DouyinOpenClientOptions.ClientKey"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_key")]
        [System.Text.Json.Serialization.JsonPropertyName("client_key")]
        public string? ClientKey { get; set; }

        /// <summary>
        /// 获取或设置抖音开放平台 WebhookSecret。如果不指定将使用构造 <see cref="DouyinOpenClient"/> 时的 <see cref="DouyinOpenClientOptions.WebhookSecret"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("client_secret")]
        public string? WebhookSecret { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置能力范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scope")]
        [System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }
    }
}
