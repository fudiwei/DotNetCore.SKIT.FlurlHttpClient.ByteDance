namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/user/info/ 接口的响应。</para>
    /// </summary>
    public class ResearchUserInfoResponse : TikTokV2Response<ResearchUserInfoResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置用户头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar_url")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
                public string AvatarUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户展示名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("display_name")]
                [System.Text.Json.Serialization.JsonPropertyName("display_name")]
                public string DisplayName { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户个人描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bio_description")]
                [System.Text.Json.Serialization.JsonPropertyName("bio_description")]
                public string BioDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否已认证。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_verified")]
                [System.Text.Json.Serialization.JsonPropertyName("is_verified")]
                public bool IsVerified { get; set; }

                /// <summary>
                /// 获取或设置粉丝数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follower_count")]
                [System.Text.Json.Serialization.JsonPropertyName("follower_count")]
                public long FollowerCount { get; set; }

                /// <summary>
                /// 获取或设置关注数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("following_count")]
                [System.Text.Json.Serialization.JsonPropertyName("following_count")]
                public long FollowingCount { get; set; }

                /// <summary>
                /// 获取或设置收到点赞数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("likes_count")]
                [System.Text.Json.Serialization.JsonPropertyName("likes_count")]
                public long LikesCount { get; set; }

                /// <summary>
                /// 获取或设置上传视频数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_count")]
                [System.Text.Json.Serialization.JsonPropertyName("video_count")]
                public long VideoCount { get; set; }
            }
        }
    }
}
