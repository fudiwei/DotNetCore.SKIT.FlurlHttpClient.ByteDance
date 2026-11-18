namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/video_bc/query/ 接口的响应。</para>
    /// </summary>
    public class AppsVideoBCQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Video : AppsVideoQueryV1Response.Types.Data.Types.__zz__Video
                    {
                        public static class Types
                        {
                            public class Statistics : AppsVideoQueryV1Response.Types.Data.Types.Video.Types.Statistics
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置统计数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statistics")]
                        [System.Text.Json.Serialization.JsonPropertyName("statistics")]
                        public Types.Statistics? Statistics { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public List<Types.Video>? VideoList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data? Data { get; set; }
    }
}
