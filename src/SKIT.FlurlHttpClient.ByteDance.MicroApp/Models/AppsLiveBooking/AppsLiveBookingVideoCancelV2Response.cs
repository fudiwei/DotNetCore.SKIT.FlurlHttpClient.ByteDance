namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v2/live_booking/video_cancel/ 接口的响应。</para>
    /// </summary>
    public class AppsLiveBookingVideoCancelV2Response : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Result { get; set; }
    }
}
