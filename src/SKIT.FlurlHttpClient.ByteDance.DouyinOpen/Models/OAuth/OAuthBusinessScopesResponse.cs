namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/business_scopes/ 接口的响应。</para>
    /// </summary>
    public class OAuthBusinessScopesResponse : DouyinOpenResponse
    {
        /// <summary>
        /// 获取或设置接口返回消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string[] Data { get; set; } = default!;
    }
}
