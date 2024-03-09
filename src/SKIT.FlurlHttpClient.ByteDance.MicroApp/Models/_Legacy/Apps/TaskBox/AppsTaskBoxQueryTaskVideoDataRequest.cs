using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/query_task_video_data 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-08 下线。")]
    public class AppsTaskBoxQueryTaskVideoDataRequest : AppsTaskBoxRequestBase
    {
        /// <summary>
        /// 获取或设置任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("task_ids")]
        public IList<long> TaskIdList { get; set; } = new List<long>();

        /// <summary>
        /// 获取或设置视频发布时间起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_publish_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("video_publish_start_time")]
        public long StartPublishTimestamp { get; set; }

        /// <summary>
        /// 获取或设置视频发布时间终止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_publish_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("video_publish_end_time")]
        public long EndPublishTimestamp { get; set; }
    }
}
