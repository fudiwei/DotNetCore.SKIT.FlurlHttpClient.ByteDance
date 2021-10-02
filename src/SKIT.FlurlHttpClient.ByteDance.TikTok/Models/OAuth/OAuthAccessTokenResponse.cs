using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /oauth/access_token 接口的响应。</para>
    /// </summary>
    public class OAuthAccessTokenResponse : TikTokResponse<OAuthAccessTokenResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : PlatformOAuthConnectResponse.Types.Data
            {
            }
        }

        /// <summary>
        /// 获取或设置返回信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
