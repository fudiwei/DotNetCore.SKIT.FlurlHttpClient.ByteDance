using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/video/update 接口的请求。</para>
    /// </summary>
    public class FileVideoUpdateRequest : OceanEngineRequest
    {
        public static class Types
        {
            public class Video
            {
                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                public string VideoId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频文件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("filename")]
                [System.Text.Json.Serialization.JsonPropertyName("filename")]
                public string VideoFileName { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置广告主 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_id")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
        public long AdvertiserId { get; set; }

        /// <summary>
        /// 获取或设置视频列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("videos")]
        [System.Text.Json.Serialization.JsonPropertyName("videos")]
        public IList<Types.Video> VideoList { get; set; } = new List<Types.Video>();
    }
}
