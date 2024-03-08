namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/default/set 接口的响应。</para>
    /// </summary>
    public class WebcastCardDefaultSetResponse : DouyinMicroAppWebcastResponse
    {
        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置审核反馈。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("feedback")]
        [System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public string? Feedback { get; set; }
    }
}
