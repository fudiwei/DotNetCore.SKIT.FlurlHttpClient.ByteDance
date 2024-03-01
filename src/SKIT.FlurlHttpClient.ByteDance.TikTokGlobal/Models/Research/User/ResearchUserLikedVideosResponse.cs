namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/user/liked_videos/ 接口的响应。</para>
    /// </summary>
    public class ResearchUserLikedVideosResponse : TikTokV2Response<ResearchUserLikedVideosResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long VideoId { get; set; }

                        /// <summary>
                        /// 获取或设置作者用户名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("username")]
                        [System.Text.Json.Serialization.JsonPropertyName("username")]
                        public string Username { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地区代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
                        public string RegionCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_count")]
                        public long LikeCount { get; set; }

                        /// <summary>
                        /// 获取或设置评论次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                        public long CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置分享次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                        public long ShareCount { get; set; }

                        /// <summary>
                        /// 获取或设置观看次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_count")]
                        public long ViewCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置音乐 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("music_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("music_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? MusicId { get; set; }

                        /// <summary>
                        /// 获取或设置话题标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("hashtag_names")]
                        [System.Text.Json.Serialization.JsonPropertyName("hashtag_names")]
                        public string[]? HashtagNameList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_liked_videos")]
                [System.Text.Json.Serialization.JsonPropertyName("user_liked_videos")]
                public Types.Video[] VideoList { get; set; } = default!;

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
