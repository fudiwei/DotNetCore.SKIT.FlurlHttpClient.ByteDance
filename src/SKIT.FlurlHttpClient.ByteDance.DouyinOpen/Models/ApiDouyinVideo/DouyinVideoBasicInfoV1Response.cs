namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/douyin/v1/video/video_basic_info/ 接口的响应。</para>
    /// </summary>
    public class DouyinVideoBasicInfoV1Response : DouyinOpenResponse<DouyinVideoBasicInfoV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                        public string ItemId { get; set; } = default!;

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
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover")]
                        public string CoverUrl { get; set; } = default!;

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
