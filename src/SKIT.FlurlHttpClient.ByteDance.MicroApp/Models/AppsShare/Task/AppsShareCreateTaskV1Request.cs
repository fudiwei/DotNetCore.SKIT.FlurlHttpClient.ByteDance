namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/share/create_task/ 接口的请求。</para>
    /// </summary>
    public class AppsShareCreateTaskV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置任务类型。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_type")]
        [System.Text.Json.Serialization.JsonPropertyName("task_type")]
        public int TaskType { get; set; } = 1;

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
    }
}
