namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v2/taskbox/query_task_video_status/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxQueryTaskVideoStatusV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置视频发布起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_publish_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("video_publish_start_time")]
        public long StartVideoPublishTimestamp { get; set; }

        /// <summary>
        /// 获取或设置视频发布终止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_publish_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("video_publish_end_time")]
        public long EndVideoPublishTimestamp { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_num")]
        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置团长 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public long? AgentId { get; set; }

        /// <summary>
        /// 获取或设置达人抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("douyin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("douyin_id")]
        public string? DouyinId { get; set; }
    }
}
