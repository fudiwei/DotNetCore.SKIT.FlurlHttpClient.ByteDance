using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/query_task_video_data 接口的请求。</para>
    /// </summary>
    public class AppsTaskBoxQueryTaskVideoDataRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

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
