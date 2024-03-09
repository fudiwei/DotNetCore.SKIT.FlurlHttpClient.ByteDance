namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/get 接口的请求。</para>
    /// </summary>
    public class WebcastCardGetRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string PagePath { get; set; } = string.Empty;
    }
}
