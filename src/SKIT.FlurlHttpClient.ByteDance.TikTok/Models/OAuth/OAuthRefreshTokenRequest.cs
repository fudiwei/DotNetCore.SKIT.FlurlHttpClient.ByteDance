namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/refresh_token 接口的请求。</para>
    /// </summary>
    public class OAuthRefreshTokenRequest : TikTokRequest
    {
        /// <summary>
        /// 获取或设置刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RefreshToken { get; set; } = "refresh_token";
    }
}
