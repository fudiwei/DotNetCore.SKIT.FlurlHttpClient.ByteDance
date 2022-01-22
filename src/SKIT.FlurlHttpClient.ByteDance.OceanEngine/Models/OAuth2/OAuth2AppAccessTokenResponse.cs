namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth2/app_access_token 接口的响应。</para>
    /// </summary>
    public class OAuth2AppAccessTokenResponse : OceanEngineResponse<OAuth2AppAccessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置应用级调用接口的凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("app_access_token")]
                public string AccessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置凭证有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int ExpiresIn { get; set; }
            }
        }
    }
}
