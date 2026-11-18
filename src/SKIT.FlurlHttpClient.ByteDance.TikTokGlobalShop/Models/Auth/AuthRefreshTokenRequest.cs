namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /token/refresh 接口的请求。</para>
    /// </summary>
    public class AuthRefreshTokenRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置授权类型。
        /// <para>默认值："refresh_token"</para>
        /// <remarks><i>（使用默认值即可，无需修改）</i></remarks>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? GrantType { get; set; } = "refresh_token";

        /// <summary>
        /// 获取或设置刷新令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? RefreshToken { get; set; }
    }
}
