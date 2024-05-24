using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v2/task/create_live/ 接口的请求。</para>
    /// </summary>
    public class AppsTaskCreateLiveV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置任务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_name")]
        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string TaskName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置任务结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置条件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conditions")]
        [System.Text.Json.Serialization.JsonPropertyName("conditions")]
        public IList<string>? ConditionList { get; set; }

        /// <summary>
        /// 获取或设置条件阈值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("condition_value")]
        [System.Text.Json.Serialization.JsonPropertyName("condition_value")]
        public IList<long>? ConditionValueList { get; set; }

        /// <summary>
        /// 获取或设置主播抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aweme_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aweme_id")]
        public string? AwemeId { get; set; }
    }
}
