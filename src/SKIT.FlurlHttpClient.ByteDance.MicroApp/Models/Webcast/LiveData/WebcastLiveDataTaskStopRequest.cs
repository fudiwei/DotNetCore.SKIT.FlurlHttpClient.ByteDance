namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /live_data/task/stop 接口的请求。</para>
    /// </summary>
    public class WebcastLiveDataTaskStopRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小玩法的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("roomid")]
        [System.Text.Json.Serialization.JsonPropertyName("roomid")]
        public string RoomId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播间消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
        public string? MessageType { get; set; }
    }
}
