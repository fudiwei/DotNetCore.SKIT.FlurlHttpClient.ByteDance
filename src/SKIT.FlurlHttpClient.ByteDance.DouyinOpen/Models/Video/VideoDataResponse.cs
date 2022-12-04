namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/data 接口的响应。</para>
    /// </summary>
    public class VideoDataResponse : DouyinOpenResponse<VideoDataResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Video : VideoListResponse.Types.Data.Types.Video
                    {
                        public static new class Types
                        {
                            public class Statistics : VideoListResponse.Types.Data.Types.Video.Types.Statistics
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置文章 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statistics")]
                        [System.Text.Json.Serialization.JsonPropertyName("statistics")]
                        public new Types.Statistics Statistics { get; set; } = default!;
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
