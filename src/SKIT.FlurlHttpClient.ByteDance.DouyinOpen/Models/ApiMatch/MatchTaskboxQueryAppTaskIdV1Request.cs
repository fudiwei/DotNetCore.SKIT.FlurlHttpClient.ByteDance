namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/match/v1/taskbox/query_app_task_id/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskboxQueryAppTaskIdV1Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务创建起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_start_time")]
        public long StartCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置任务创建终止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_end_time")]
        public long EndCreateTimestamp { get; set; }
    }
}
