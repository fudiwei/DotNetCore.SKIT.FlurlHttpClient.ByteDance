namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v2/live_booking/video_cancel/ 接口的请求。</para>
    /// </summary>
    public class AppsLiveBookingVideoCancelV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频 ID。与字段 <see cref="VideoUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// 获取或设置视频分享链接。与字段 <see cref="ItemId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_url")]
        [System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public string? VideoUrl { get; set; }
    }
}
