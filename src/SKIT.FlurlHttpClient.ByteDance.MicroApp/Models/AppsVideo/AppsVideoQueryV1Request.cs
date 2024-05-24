using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/video/query/ 接口的请求。</para>
    /// </summary>
    public class AppsVideoQueryV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频 ID 列表。与字段 <see cref="VideoIdList"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("item_ids")]
        public IList<string>? ItemIdList { get; set; }

        /// <summary>
        /// 获取或设置视频 ID 列表。与字段 <see cref="ItemIdList"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("video_ids")]
        public IList<string>? VideoIdList { get; set; }
    }
}
