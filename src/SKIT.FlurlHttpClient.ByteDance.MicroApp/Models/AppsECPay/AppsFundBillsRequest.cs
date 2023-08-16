namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/fund/bills 接口的请求。</para>
    /// </summary>
    public class AppsFundBillsRequest : ByteDanceMicroAppRequest
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
        /// 获取或设置商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string DateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置账户类型。
        /// <para>默认值：ALL</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置收支类型。
        /// <para>默认值：ALL</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_type")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_type")]
        public string PaymentType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置交易类型。
        /// <para>默认值：ALL</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }
    }
}
