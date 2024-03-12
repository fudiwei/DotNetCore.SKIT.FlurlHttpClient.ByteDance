namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/renew_refresh_token/ 接口的响应。</para>
    /// </summary>
    public class OAuthRenewRefreshTokenResponse : DouyinOpenResponse<OAuthRenewRefreshTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置刷新令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
                public string RefreshToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置刷新令牌有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public long RefreshTokenExpiresIn { get; set; }
            }
        }
    }
}
