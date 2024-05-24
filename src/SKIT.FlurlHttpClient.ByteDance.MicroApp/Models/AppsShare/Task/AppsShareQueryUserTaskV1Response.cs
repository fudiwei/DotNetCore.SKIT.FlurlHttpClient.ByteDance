namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/share/query_user_task/ 接口的响应。</para>
    /// </summary>
    public class AppsShareQueryUserTaskV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否有效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_valid")]
                [System.Text.Json.Serialization.JsonPropertyName("is_valid")]
                public bool IsValid { get; set; }

                /// <summary>
                /// 获取或设置目标次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("target_count")]
                [System.Text.Json.Serialization.JsonPropertyName("target_count")]
                public int TargetCount { get; set; }

                /// <summary>
                /// 获取或设置成功次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_count")]
                [System.Text.Json.Serialization.JsonPropertyName("success_count")]
                public int SuccessCount { get; set; }

                /// <summary>
                /// 获取或设置是否已完成。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("completed")]
                [System.Text.Json.Serialization.JsonPropertyName("completed")]
                public bool IsCompleted { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
