namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/ecpay/saas/create_merchant 接口的响应。</para>
    /// </summary>
    public class AppsECPaySaaSCreateMerchantResponse : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置申请单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_id")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_id")]
        public string ApplyId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; } = default!;
    }
}
