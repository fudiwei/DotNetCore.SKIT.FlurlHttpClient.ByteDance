namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/video_data/ 接口的响应。</para>
    /// </summary>
    public class VideoDataResponse : DouyinOpenResponse<VideoDataResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Video
                    {
                        public static class Types
                        {
                            public class Statistics : VideoListResponse.Types.Data.Types.Video.Types.Statistics
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                        public string ItemId { get; set; } = default!;

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
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover")]
                        public string CoverUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频分享 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_url")]
                        public string ShareUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否置顶。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_top")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_top")]
                        public bool IsTop { get; set; }

                        /// <summary>
                        /// 获取或设置是否审核结束。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_reviewed")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_reviewed")]
                        public bool IsReviewed { get; set; }

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
                        public int? MediaType { get; set; }

                        /// <summary>
                        /// 获取或设置文章 ID。
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
    }
}
