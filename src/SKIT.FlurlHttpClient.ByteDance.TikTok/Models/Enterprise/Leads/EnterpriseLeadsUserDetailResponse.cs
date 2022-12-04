namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /enterprise/leads/user/detail 接口的响应。</para>
    /// </summary>
    public class EnterpriseLeadsUserDetailResponse : TikTokResponse<EnterpriseLeadsUserDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class Tag : EnterpriseLeadsTagListResponse.Types.Data.Types.Tag
                    {
                    }
                }

                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_id")]
                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户的微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wechat")]
                [System.Text.Json.Serialization.JsonPropertyName("wechat")]
                public string? WechatNumber { get; set; }

                /// <summary>
                /// 获取或设置用户的电话号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("telephone")]
                [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                public string? TelephoneNumber { get; set; }

                /// <summary>
                /// 获取或设置性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                public int Gender { get; set; }

                /// <summary>
                /// 获取或设置年龄。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("age")]
                [System.Text.Json.Serialization.JsonPropertyName("age")]
                public int Age { get; set; }

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string AvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置所在城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = default!;

                /// <summary>
                /// 获取或设置意向状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leads_level")]
                [System.Text.Json.Serialization.JsonPropertyName("leads_level")]
                public int LeadsLevel { get; set; }

                /// <summary>
                /// 获取或设置是否已关注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_follow")]
                [System.Text.Json.Serialization.JsonPropertyName("is_follow")]
                public bool IsFollowed { get; set; }

                /// <summary>
                /// 获取或设置标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tag_list")]
                [System.Text.Json.Serialization.JsonPropertyName("tag_list")]
                public Types.Tag[]? TagList { get; set; }
            }
        }
    }
}
