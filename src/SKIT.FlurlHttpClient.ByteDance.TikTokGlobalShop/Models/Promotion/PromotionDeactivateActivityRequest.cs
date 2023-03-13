namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/deactivate 接口的请求。</para>
    /// </summary>
    public class PromotionDeactivateActivityRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial_no")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial_no")]
        public string RequestSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置促销 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; } = string.Empty;
    }
}
