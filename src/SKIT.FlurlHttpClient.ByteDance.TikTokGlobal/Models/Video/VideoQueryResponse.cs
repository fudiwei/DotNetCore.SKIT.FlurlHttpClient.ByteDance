namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/query/ 接口的响应。</para>
    /// </summary>
    public class VideoQueryResponse : TikTokV2Response<VideoQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video : VideoListResponse.Types.Data.Types.Video
                    {
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("videos")]
                [System.Text.Json.Serialization.JsonPropertyName("videos")]
                public Types.Video[] VideoList { get; set; } = default!;
            }
        }
    }
}
