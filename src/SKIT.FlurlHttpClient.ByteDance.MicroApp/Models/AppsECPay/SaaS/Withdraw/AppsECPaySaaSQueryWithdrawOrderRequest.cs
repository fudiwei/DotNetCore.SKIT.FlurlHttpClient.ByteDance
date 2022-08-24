namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/query_withdraw_order 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSQueryWithdrawOrderRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序第三方平台应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thirdparty_id")]
        [System.Text.Json.Serialization.JsonPropertyName("thirdparty_id")]
        public string? ComponentAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
        public string MerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_type")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
        public string ChannelType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string OutOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sign")]
        [System.Text.Json.Serialization.JsonPropertyName("sign")]
        public string? Signature { get; set; }
    }
}
