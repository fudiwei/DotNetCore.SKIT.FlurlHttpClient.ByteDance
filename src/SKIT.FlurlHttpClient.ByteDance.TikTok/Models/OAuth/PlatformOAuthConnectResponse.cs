using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /platform/oauth/connect 接口的响应。</para>
    /// </summary>
    public class PlatformOAuthConnectResponse : TikTokResponse<PlatformOAuthConnectResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("error_code")]
                [System.Text.Json.Serialization.JsonPropertyName("error_code")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? ErrorDescription { get; set; }

                /// <summary>
                /// 获取或设置接口调用凭证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token")]
                public string? AccessToken { get; set; }

                /// <summary>
                /// 获取或设置授权用户唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置用户授权的作用域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scope")]
                [System.Text.Json.Serialization.JsonPropertyName("scope")]
                public string? Scope { get; set; }

                /// <summary>
                /// 获取或设置凭证有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
                public int? ExpiresIn { get; set; }

                /// <summary>
                /// 获取或设置刷新令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_token")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
                public string? RefreshToken { get; set; }

                /// <summary>
                /// 获取或设置刷新令牌有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refresh_expires_in")]
                [System.Text.Json.Serialization.JsonPropertyName("refresh_expires_in")]
                public int? RefreshTokenExpiresIn { get; set; }
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
