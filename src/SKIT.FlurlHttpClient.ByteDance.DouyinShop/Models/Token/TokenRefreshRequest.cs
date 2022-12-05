namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /token/refresh 接口的请求。</para>
    /// </summary>
    public class TokenRefreshRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置授权类型。
        /// <para>默认值：refresh_token</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        public string GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 获取或设置刷新 AccessToken 的令牌。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refresh_token")]
        [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;
    }
}
