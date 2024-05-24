using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/taskbox/query_app_task_id 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-08 下线。")]
    public class AppsTaskBoxQueryAppTaskIdResponse : AppsTaskBoxResponseBase
    {
        /// <summary>
        /// 获取或设置任务 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public long[] TaskIdList { get; set; } = default!;
    }
}
