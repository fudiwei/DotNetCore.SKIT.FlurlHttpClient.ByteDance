namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/saas/merchant_withdraw 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSMerchantWithdrawResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置平台提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = default!;
    }
}
