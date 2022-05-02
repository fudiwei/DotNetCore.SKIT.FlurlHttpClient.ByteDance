namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/query_merchant_status 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSQueryMerchantStatusResponse : ByteDanceMicroAppResponse
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置微信支付渠道进件状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx")]
        [System.Text.Json.Serialization.JsonPropertyName("wx")]
        public int WechatpayStatus { get; set; }

        /// <summary>
        /// 获取或设置支付宝渠道进件状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alipay")]
        [System.Text.Json.Serialization.JsonPropertyName("alipay")]
        public int AlipayStatus { get; set; }
    }
}
