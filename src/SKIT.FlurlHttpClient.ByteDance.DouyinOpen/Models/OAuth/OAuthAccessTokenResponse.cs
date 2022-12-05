namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/access_token 接口的响应。</para>
    /// </summary>
    public class OAuthAccessTokenResponse : DouyinOpenResponse<OAuthAccessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置接口调用凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token")]
                public string AccessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户授权的作用域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public string Scope { get; set; } = default!;

                /// <summary>
                /// 获取或设置凭证有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置刷新令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
                public string RefreshToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置刷新令牌有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_expires_in")]
                public int RefreshTokenExpiresIn { get; set; }
            }
        }
    }
}
