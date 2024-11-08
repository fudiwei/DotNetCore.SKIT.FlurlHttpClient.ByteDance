namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /audience/join_game 接口的请求。</para>
    /// </summary>
    public class WebcastAudienceJoinGameRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置​房间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
        public string RoomId { get; set; } = string.Empty;
    }
}
