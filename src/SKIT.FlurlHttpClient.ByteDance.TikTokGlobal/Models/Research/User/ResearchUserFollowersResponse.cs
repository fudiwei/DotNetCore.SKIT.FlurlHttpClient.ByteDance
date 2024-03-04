namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/user/followers/ 接口的响应。</para>
    /// </summary>
    public class ResearchUserFollowersResponse : TikTokV2Response<ResearchUserFollowersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Follower
                    {
                        /// <summary>
                        /// 获取或设置用户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("username")]
                        [System.Text.Json.Serialization.JsonPropertyName("username")]
                        public string Username { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户展示名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_name")]
                        public string DisplayName { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置粉丝列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_followers")]
                [System.Text.Json.Serialization.JsonPropertyName("user_followers")]
                public Types.Follower[] FollowerList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
