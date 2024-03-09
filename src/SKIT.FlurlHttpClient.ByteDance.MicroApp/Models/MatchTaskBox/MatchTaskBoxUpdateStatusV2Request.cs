using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/update_status/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxUpdateStatusV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_status")]
        [System.Text.Json.Serialization.JsonPropertyName("task_status")]
        public int TaskStatus { get; set; }
    }
}
