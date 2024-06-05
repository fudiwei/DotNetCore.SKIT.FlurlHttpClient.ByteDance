namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /webcastmate/info 接口的请求。</para>
    /// </summary>
    public class WebcastWebcastMateInfoRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置直播伴侣 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("token")]
        [System.Text.Json.Serialization.JsonPropertyName("token")]
        public string WebcastMateToken { get; set; } = string.Empty;
    }
}
