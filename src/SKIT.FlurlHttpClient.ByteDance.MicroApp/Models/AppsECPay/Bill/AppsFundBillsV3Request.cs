namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v3/fund/bills/ 接口的请求。</para>
    /// </summary>
    public class AppsFundBillsV3Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置账户类型。
        /// <para>默认值："ALL"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置交易类型。
        /// <para>默认值："ALL"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public string TradeType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置收支类型。
        /// <para>默认值："ALL"</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_type")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_type")]
        public string PaymentType { get; set; } = "ALL";

        /// <summary>
        /// 获取或设置账单日期字符串（格式：yyyyMMdd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string BillDateString { get; set; } = string.Empty;
    }
}
