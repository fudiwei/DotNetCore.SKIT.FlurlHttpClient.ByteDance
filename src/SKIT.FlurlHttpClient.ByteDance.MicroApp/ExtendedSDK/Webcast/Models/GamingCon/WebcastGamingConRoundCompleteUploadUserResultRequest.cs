using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /gaming_con/round/complete_upload_user_result 接口的请求。</para>
    /// </summary>
    public class WebcastGamingConRoundCompleteUploadUserResultRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置主播的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("anchor_open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("anchor_open_id")]
        public string AnchorOpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置​房间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_id")]
        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
        public string RoomId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置​​对局 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("round_id")]
        [System.Text.Json.Serialization.JsonPropertyName("round_id")]
        public long RoundId { get; set; }

        /// <summary>
        /// 获取或设置上传完成时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complete_time")]
        [System.Text.Json.Serialization.JsonPropertyName("complete_time")]
        public long? CompleteTimestamp { get; set; }
    }
}
