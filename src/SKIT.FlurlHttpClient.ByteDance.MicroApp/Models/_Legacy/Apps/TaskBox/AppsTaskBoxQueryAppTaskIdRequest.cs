using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/query_app_task_id 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2024-01-08 下线。")]
    public class AppsTaskBoxQueryAppTaskIdRequest : AppsTaskBoxRequestBase
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
