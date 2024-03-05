namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /business/diamond/order_ack 接口的响应。</para>
    /// </summary>
    public class WebcastBusinessDiamondOrderAckResponse : DouyinMicroAppWebcastResponse
    {
        /// <summary>
        /// 获取或设置支付状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ack_status")]
        [System.Text.Json.Serialization.JsonPropertyName("ack_status")]
        public int AckStatus { get; set; }
    }
}
