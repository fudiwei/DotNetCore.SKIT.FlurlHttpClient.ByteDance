namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/userinfo/ 接口的请求。</para>
    /// </summary>
    public class OAuthUserInfoRequest : DouyinOpenRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;
    }
}
