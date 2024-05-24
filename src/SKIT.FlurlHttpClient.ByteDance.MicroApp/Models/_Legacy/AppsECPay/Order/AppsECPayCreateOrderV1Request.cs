namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/v1/create_order 接口的请求。</para>
    /// </summary>
    public class AppsECPayCreateOrderV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置门店收款商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("store_uid")]
        public string? StoreMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subject")]
        [System.Text.Json.Serialization.JsonPropertyName("subject")]
        public string Subject { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body")]
        [System.Text.Json.Serialization.JsonPropertyName("body")]
        public string Body { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_time")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_time")]
        public int ValidTime { get; set; }

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cp_extra")]
        [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置是否屏蔽担保支付的推送消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("disable_msg")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("disable_msg")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsMessageDisabled { get; set; }

        /// <summary>
        /// 获取或设置担保支付消息跳转页面。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg_page")]
        [System.Text.Json.Serialization.JsonPropertyName("msg_page")]
        public string? MessagePagePath { get; set; }
    }
}
