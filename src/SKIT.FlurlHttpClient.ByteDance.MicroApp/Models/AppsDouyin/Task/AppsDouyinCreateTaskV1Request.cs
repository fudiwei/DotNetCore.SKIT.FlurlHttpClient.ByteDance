using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/douyin/create_task/ 接口的请求。</para>
    /// </summary>
    public class AppsDouyinCreateTaskV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置任务类型。
        /// <para>默认值：2</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_type")]
        [System.Text.Json.Serialization.JsonPropertyName("task_type")]
        public int TaskType { get; set; } = 2;

        /// <summary>
        /// 获取或设置规则类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_type")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_type")]
        public int RuleType { get; set; }

        /// <summary>
        /// 获取或设置目标次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_count")]
        [System.Text.Json.Serialization.JsonPropertyName("target_count")]
        public int TargetCount { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置挂载链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mount_link")]
        [System.Text.Json.Serialization.JsonPropertyName("mount_link")]
        public string? MountLink { get; set; }

        /// <summary>
        /// 获取或设置发布类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_type")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_type")]
        public IList<int>? PublishTypeList { get; set; }

        /// <summary>
        /// 获取或设置话题标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags")]
        [System.Text.Json.Serialization.JsonPropertyName("tags")]
        public IList<string>? TagList { get; set; }
    }
}
