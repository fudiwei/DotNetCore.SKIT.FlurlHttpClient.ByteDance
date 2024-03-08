namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/query_app_task_id/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxQueryAppTaskIdV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置创建时间起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_start_time")]
        public long StartCreateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置创建时间终止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_end_time")]
        public long EndCreateTimestamp { get; set; }
    }
}
