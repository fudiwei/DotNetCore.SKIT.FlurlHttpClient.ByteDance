namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/fulfillment/verify_cancel 接口的请求。</para>
    /// </summary>
    public class AppsTradeFulfillmentVerifyCancelV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
        public string CertificateId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置核销 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
        public string VerifyId { get; set; } = string.Empty;
    }
}
