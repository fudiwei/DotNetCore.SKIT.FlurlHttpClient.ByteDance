namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/access_token 接口的响应。</para>
    /// </summary>
    public class OAuthAccessTokenResponse : TikTokResponse<OAuthAccessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResponseData
            {
                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? ErrorDescription { get; set; }

                /// <summary>
                /// 获取或设置错误描述链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc_url")]
                [System.Text.Json.Serialization.JsonPropertyName("desc_url")]
                public string? ErrorDescriptionUrl { get; set; }

                /// <summary>
                /// 获取或设置验证码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("captcha")]
                [System.Text.Json.Serialization.JsonPropertyName("captcha")]
                public string? Captcha { get; set; }

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

        /// <summary>
        /// 获取或设置响应状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? ResponseMessage { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && !"error".Equals(ResponseMessage);
        }
    }
}
