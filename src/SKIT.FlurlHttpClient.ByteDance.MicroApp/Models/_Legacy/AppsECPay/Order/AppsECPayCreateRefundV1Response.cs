namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/create_refund 接口的响应。</para>
    /// </summary>
    public class AppsECPayCreateRefundV1Response : DouyinMicroAppResponse
    {
        /// <summary>
        /// 获取或设置担保交易退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_no")]
        public string RefundNumber { get; set; } = default!;
    }
}
