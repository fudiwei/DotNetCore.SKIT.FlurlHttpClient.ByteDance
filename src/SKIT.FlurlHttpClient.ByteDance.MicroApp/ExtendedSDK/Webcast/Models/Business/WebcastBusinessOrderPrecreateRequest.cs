namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /business/order/pre_create 接口的请求。</para>
    /// </summary>
    public class WebcastBusinessOrderPrecreateRequest : DouyinMicroAppWebcastRequest
    {
        /// <summary>
        /// 获取或设置应用的 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppWebcastClient"/> 时的 <see cref="DouyinMicroAppWebcastClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置开发者订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置付费点。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_tag")]
        public string PayTag { get; set; } = string.Empty;

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

        /// <summary>
        /// 获取或设置通知回调 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string NotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_time")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_time")]
        public int ValidIn { get; set; }
    }
}
