namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/add_sub_merchant 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSAddSubMerchantResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置请求页面链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; } = default!;
    }
}
