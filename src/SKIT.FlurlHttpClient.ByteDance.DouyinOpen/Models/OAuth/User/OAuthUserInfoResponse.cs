namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /oauth/userinfo 接口的响应。</para>
    /// </summary>
    public class OAuthUserInfoResponse : DouyinOpenResponse<OAuthUserInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

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
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public int Gender { get; set; }

                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string AvatarUrl { get; set; } = default!;

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
                public string Country { get; set; } = default!;

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = default!;

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = default!;
            }
        }
    }
}
