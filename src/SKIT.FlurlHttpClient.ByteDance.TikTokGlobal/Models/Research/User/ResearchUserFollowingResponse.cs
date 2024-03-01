namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/user/following/ 接口的响应。</para>
    /// </summary>
    public class ResearchUserFollowingResponse : TikTokV2Response<ResearchUserFollowingResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Following
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
                /// 获取或设置关注列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_following")]
                [System.Text.Json.Serialization.JsonPropertyName("user_following")]
                public Types.Following[] FollowingList { get; set; } = default!;

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
