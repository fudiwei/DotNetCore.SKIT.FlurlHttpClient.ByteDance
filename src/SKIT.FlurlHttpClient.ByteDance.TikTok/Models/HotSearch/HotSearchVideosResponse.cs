namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /hotsearch/videos 接口的响应。</para>
    /// </summary>
    public class HotSearchVideosResponse : TikTokResponse<HotSearchVideosResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
            {
                public static class Types
                {
                    public class HotSearchVideo : VideoListResponse.Types.Data.Types.Video
                    {
                    }
                }

                /// <summary>
                /// 获取或设置热点视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.HotSearchVideo[] HotSearchVideoList { get; set; } = default!;
            }
        }
    }
}
