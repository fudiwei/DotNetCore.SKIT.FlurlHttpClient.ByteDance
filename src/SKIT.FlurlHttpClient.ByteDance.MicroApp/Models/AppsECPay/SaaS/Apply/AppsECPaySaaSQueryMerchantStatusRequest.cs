namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/query_merchant_status 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSQueryMerchantStatusRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户号。与字段 <see cref="SubMerchantId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_merchant_id")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }
    }
}
