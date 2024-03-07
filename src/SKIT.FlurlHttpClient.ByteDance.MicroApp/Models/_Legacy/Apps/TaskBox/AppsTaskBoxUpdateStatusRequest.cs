using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/update/status 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-08 下线。")]
    public class AppsTaskBoxUpdateStatusRequest : AppsTaskBoxRequestBase
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
