namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/video/query/ 接口的响应。</para>
    /// </summary>
    public class AppsVideoQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video
                    {
                        public static class Types
                        {
                            public class Statistics
                            {
                                /// <summary>
                                /// 获取或设置点赞数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("digg_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("digg_count")]
                                public int DiggCount { get; set; }

                                /// <summary>
                                /// 获取或设置下载数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("download_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("download_count")]
                                public int DownloadCount { get; set; }

                                /// <summary>
                                /// 获取或设置转发数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("forward_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("forward_count")]
                                public int ForwardCount { get; set; }

                                /// <summary>
                                /// 获取或设置播放数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("play_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("play_count")]
                                public int PlayCount { get; set; }

                                /// <summary>
                                /// 获取或设置分享数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("share_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("share_count")]
                                public int ShareCount { get; set; }

                                /// <summary>
                                /// 获取或设置评论数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("comment_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("comment_count")]
                                public int CommentCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                        public string? ItemId { get; set; }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        public string? VideoId { get; set; }

                        /// <summary>
                        /// 获取或设置视频标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_status")]
                        public int VideoStatus { get; set; }

                        /// <summary>
                        /// 获取或设置视频封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover")]
                        public string CoverUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分享链接 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url")]
                        public string ShareUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否审核结束。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_reviewed")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_reviewed")]
                        public bool IsReviewed { get; set; }

                        /// <summary>
                        /// 获取或设置是否置顶。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_top")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_top")]
                        public bool IsTop { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置媒体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_type")]
                        public int MediaType { get; set; }

                        /// <summary>
                        /// 获取或设置统计数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statistics")]
                        [System.Text.Json.Serialization.JsonPropertyName("statistics")]
                        public Types.Statistics Statistics { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Video[] VideoList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
