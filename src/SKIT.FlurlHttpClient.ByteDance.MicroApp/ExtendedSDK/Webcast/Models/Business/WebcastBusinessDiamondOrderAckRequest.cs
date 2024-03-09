namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /business/diamond/order_ack 接口的请求。</para>
    /// </summary>
    public class WebcastBusinessDiamondOrderAckRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置抖币数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diamonds")]
        [System.Text.Json.Serialization.JsonPropertyName("diamonds")]
        public int Diamonds { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;
    }
}
