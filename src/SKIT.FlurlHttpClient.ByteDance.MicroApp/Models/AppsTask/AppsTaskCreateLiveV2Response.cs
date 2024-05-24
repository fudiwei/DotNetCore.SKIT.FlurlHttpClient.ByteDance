namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v2/task/create_live/ 接口的响应。</para>
    /// </summary>
    public class AppsTaskCreateLiveV2Response : DouyinMicroAppResponse
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
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_status")]
                [System.Text.Json.Serialization.JsonPropertyName("task_status")]
                public int TaskStatus { get; set; }
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
