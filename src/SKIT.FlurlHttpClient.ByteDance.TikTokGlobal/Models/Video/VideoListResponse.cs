namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/list/ 接口的响应。</para>
    /// </summary>
    public class VideoListResponse : TikTokV2Response<VideoListResponse.Types.Data>
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
                        public string VideoId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置封面图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover_image_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
                        public string CoverImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分享链接 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url")]
                        public string ShareUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public int Duration { get; set; }

                        /// <summary>
                        /// 获取或设置视频高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置视频宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置内嵌 HTML。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("embed_html")]
                        [System.Text.Json.Serialization.JsonPropertyName("embed_html")]
                        public string EmbedHtml { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置内嵌链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("embed_link")]
                        [System.Text.Json.Serialization.JsonPropertyName("embed_link")]
                        public string EmbedLink { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置点赞次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("like_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("like_count")]
                        public long LikeCount { get; set; } = default!;

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
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("videos")]
                [System.Text.Json.Serialization.JsonPropertyName("videos")]
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
