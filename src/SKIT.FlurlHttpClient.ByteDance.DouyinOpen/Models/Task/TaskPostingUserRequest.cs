namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /task/posting/user/ 接口的请求。</para>
    /// </summary>
    public class TaskPostingUserRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("target_open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_id")]
        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_id")]
        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string VideoId { get; set; } = string.Empty;
    }
}
