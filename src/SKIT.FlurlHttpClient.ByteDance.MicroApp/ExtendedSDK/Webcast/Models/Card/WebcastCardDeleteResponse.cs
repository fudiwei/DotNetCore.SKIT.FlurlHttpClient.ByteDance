namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/delete 接口的响应。</para>
    /// </summary>
    public class WebcastCardDeleteResponse : DouyinMicroAppWebcastResponse
    {
        /// <summary>
        /// 获取或设置删除状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
