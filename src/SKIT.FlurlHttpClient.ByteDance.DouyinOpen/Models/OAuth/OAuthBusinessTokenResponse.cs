namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/business_token/ 接口的响应。</para>
    /// </summary>
    public class OAuthBusinessTokenResponse : DouyinOpenResponse<OAuthBusinessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                /// <summary>
                /// 获取或设置经营关系调用凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_token")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_token")]
                public string BusinessToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置经营关系调用凭证有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_expires_in")]
                public long BusinessExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置经营关系刷新令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_refresh_token")]
                public string BusinessRefreshToken { get; set; } = default!;

                /// <summary>
                /// 获取或设置经营关系刷新令牌有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_refresh_expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_refresh_expires_in")]
                public long BusinessRefreshTokenExpiresIn { get; set; }
            }
        }
    }
}
