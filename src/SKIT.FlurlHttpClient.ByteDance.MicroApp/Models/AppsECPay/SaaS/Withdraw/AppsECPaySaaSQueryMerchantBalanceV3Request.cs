namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/query_merchant_balance/ 接口的请求。</para>
    /// </summary>
    public class AppsECPaySaaSQueryMerchantBalanceV3Request : DouyinMicroAppRequest
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
        /// 获取或设置商户主体标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_entity")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_entity")]
        public int? MerchantEntity { get; set; }

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
    }
}
