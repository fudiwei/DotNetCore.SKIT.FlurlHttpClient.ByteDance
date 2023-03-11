using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/query/ 接口的请求。</para>
    /// </summary>
    public class VideoQueryV2Request : TikTokRequestV2
    {
        public static class Types
        {
            public class Filters
            {
                /// <summary>
                /// 获取或设置视频 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
                public IList<string>? VideoIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置要读取的字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string> FieldList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置筛选条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters")]
        [System.Text.Json.Serialization.JsonPropertyName("filters")]
        public Types.Filters Filters { get; set; } = new Types.Filters();
    }
}
