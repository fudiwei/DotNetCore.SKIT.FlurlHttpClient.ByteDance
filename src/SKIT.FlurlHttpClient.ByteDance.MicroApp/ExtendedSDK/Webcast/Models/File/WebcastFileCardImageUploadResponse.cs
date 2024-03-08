namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /file/card_image/upload 接口的响应。</para>
    /// </summary>
    public class WebcastFileCardImageUploadResponse : DouyinMicroAppWebcastResponse
    {
        /// <summary>
        /// 获取或设置图片状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
