namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /task/posting/create/ 接口的请求。</para>
    /// </summary>
    public class TaskPostingCreateRequest : DouyinOpenRequest
    {
        public static class Types
        {
            public class TaskCondition
            {
                /// <summary>
                /// 获取或设置条件。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("condition")]
                [System.Text.Json.Serialization.JsonPropertyName("condition")]
                public string Condition { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置最大值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_value")]
                [System.Text.Json.Serialization.JsonPropertyName("max_value")]
                public long MaxValue { get; set; }

                /// <summary>
                /// 获取或设置最小值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min_value")]
                [System.Text.Json.Serialization.JsonPropertyName("min_value")]
                public long MinValue { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置开始时间时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置任务条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_condition")]
        [System.Text.Json.Serialization.JsonPropertyName("task_condition")]
        public Types.TaskCondition TaskCondition { get; set; } = new Types.TaskCondition();

        /// <summary>
        /// 获取或设置任务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_name")]
        [System.Text.Json.Serialization.JsonPropertyName("task_name")]
        public string TaskName { get; set; } = string.Empty;
    }
}
