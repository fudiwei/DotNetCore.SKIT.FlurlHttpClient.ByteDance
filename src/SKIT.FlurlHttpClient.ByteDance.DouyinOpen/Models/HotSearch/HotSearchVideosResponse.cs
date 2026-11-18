namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /hotsearch/videos/ 接口的响应。</para>
    /// </summary>
    public class HotSearchVideosResponse : DouyinOpenResponse<HotSearchVideosResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class HotSearchVideo : DouyinVideoListV1Response.Types.Data.Types.__zz__Video
                    {
                        public static class Types
                        {
                            public class Statistics : DouyinVideoListV1Response.Types.Data.Types.Video.Types.Statistics
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置文章 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statistics")]
                        [System.Text.Json.Serialization.JsonPropertyName("statistics")]
                        public Types.Statistics? Statistics { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置热点视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public List<Types.HotSearchVideo>? HotSearchVideoList { get; set; }
            }
        }
    }
}
