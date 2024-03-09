namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [GET] /live_data/task/get 接口的请求。</para>
    /// </summary>
    public class WebcastLiveDataTaskGetRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置直播间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RoomId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置直播间消息类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MessageType { get; set; }
    }
}
