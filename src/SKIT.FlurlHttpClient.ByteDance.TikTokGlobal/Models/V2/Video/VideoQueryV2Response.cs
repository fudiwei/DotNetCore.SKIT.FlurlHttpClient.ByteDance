namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/query/ 接口的响应。</para>
    /// </summary>
    public class VideoQueryV2Response : TikTokResponseV2<VideoQueryV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video : VideoListV2Response.Types.Data.Types.Video
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
