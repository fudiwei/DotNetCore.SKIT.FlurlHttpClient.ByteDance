namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/create_return 接口的请求。</para>
    /// </summary>
    public class AppsECPayCreateReturnV1Request : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户结算单号。与字段 <see cref="SettleNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_settle_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
        public string? OutSettleNumber { get; set; }

        /// <summary>
        /// 获取或设置担保交易分帐单号。与字段 <see cref="OutSettleNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_no")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_no")]
        public string? SettleNumber { get; set; }

        /// <summary>
        /// 获取或设置商户回退单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_return_no")]
        public string OutReturnNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回退描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("return_desc")]
        public string ReturnDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回退商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("return_amount")]
        public int ReturnAmount { get; set; }

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
    }
}
