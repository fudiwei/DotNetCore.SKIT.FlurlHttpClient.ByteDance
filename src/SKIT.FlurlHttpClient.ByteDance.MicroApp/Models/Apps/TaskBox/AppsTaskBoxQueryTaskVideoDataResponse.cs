namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/query_task_video_data 接口的响应。</para>
    /// </summary>
    public class AppsTaskBoxQueryTaskVideoDataResponse : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Video
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long TaskId { get; set; }

                /// <summary>
                /// 获取或设置任务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_name")]
                [System.Text.Json.Serialization.JsonPropertyName("task_name")]
                public string TaskName { get; set; } = default!;

                /// <summary>
                /// 获取或设置作者抖音号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("douyin_id")]
                [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
                public string DouyinId { get; set; } = default!;

                /// <summary>
                /// 获取或设置作者名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("author")]
                [System.Text.Json.Serialization.JsonPropertyName("author")]
                public string Author { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("micro_app_title")]
                [System.Text.Json.Serialization.JsonPropertyName("micro_app_title")]
                public string MicroAppTitle { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long VideoId { get; set; }

                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_title")]
                [System.Text.Json.Serialization.JsonPropertyName("video_title")]
                public string VideoTitle { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("VideoLink")]
                [System.Text.Json.Serialization.JsonPropertyName("VideoLink")]
                public string VideoUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置发布时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_time")]
                public long PublishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置视频播放量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_views")]
                [System.Text.Json.Serialization.JsonPropertyName("video_views")]
                public int ViewCount { get; set; }

                /// <summary>
                /// 获取或设置视频点击量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("clicks")]
                [System.Text.Json.Serialization.JsonPropertyName("clicks")]
                public int ClickCount { get; set; }

                /// <summary>
                /// 获取或设置视频评论数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comments")]
                [System.Text.Json.Serialization.JsonPropertyName("comments")]
                public int CommentCount { get; set; }

                /// <summary>
                /// 获取或设置视频点赞数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("likes")]
                [System.Text.Json.Serialization.JsonPropertyName("likes")]
                public int LikeCount { get; set; }

                /// <summary>
                /// 获取或设置视频分享数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shares")]
                [System.Text.Json.Serialization.JsonPropertyName("shares")]
                public int ShareCount { get; set; }

                /// <summary>
                /// 获取或设置预计收益（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expected_profit")]
                [System.Text.Json.Serialization.JsonPropertyName("expected_profit")]
                public double ExpectedProfit { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("error")]
        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("message")]
        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置视频列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Video[] VideoList { get; set; } = default!;
    }
}
