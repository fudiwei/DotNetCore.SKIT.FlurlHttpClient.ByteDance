namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /live/booking/text_close/ 接口的响应。</para>
    /// </summary>
    public class LiveBookingTextCloseResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置操作结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success")]
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Result { get; set; }
    }
}
