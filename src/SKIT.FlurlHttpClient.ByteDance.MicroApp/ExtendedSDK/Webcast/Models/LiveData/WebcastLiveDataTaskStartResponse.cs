namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /live_data/task/start 接口的响应。</para>
    /// </summary>
    public class WebcastLiveDataTaskStartResponse : DouyinMicroAppWebcastResponse
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
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求日志 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logid")]
        [System.Text.Json.Serialization.JsonPropertyName("logid")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
