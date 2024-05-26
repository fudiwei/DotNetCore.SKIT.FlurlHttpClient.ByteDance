namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /live/booking/text_create/ 接口的响应。</para>
    /// </summary>
    public class LiveBookingTextCreateResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Result { get; set; }

        /// <summary>
        /// 获取或设置预约 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("booking_id")]
        [System.Text.Json.Serialization.JsonPropertyName("booking_id")]
        public string? BookingId { get; set; }
    }
}
