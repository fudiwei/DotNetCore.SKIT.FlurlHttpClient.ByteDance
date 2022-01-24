namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth2/access_token 接口的响应。</para>
    /// </summary>
    public class OAuth2AccessTokenResponse : OceanEngineResponse<OAuth2AccessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置调用接口的凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token")]
                public string AccessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置凭证有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置接口刷新令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
                public string RefreshToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置接口刷新令牌有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token_expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token_expires_in")]
                public int RefreshTokenExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置授权的账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("advertiser_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("advertiser_ids")]
                public long[] AdvertiserIdList { get; set; } = default!;
            }
        }
    }
}
