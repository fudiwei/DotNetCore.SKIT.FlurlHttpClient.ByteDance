namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/taskbox/query_app_task_id 接口的请求。</para>
    /// </summary>
    public class AppsTaskBoxQueryAppTaskIdRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

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
