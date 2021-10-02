using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/userinfo 接口的响应。</para>
    /// </summary>
    public class OAuthUserInfoResponse : TikTokResponse<OAuthUserInfoResponse.Types.Data>
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
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? ErrorDescription { get; set; }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置用户的 UnionId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("union_id")]
                [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                public string? UnionId { get; set; }

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string? Nickname { get; set; }

                /// <summary>
                /// 获取或设置用户性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public int? Gender { get; set; }

                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string? AvatarUrl { get; set; }

                /// <summary>
                /// 获取或设置账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("e_account_role")]
                [System.Text.Json.Serialization.JsonPropertyName("e_account_role")]
                public string? EAccountRole { get; set; }

                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }
            }
        }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && Data?.ErrorCode == 0;
        }
    }
}
