namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/shipping_info/update 接口的请求。</para>
    /// </summary>
    public class FulfillmentUpdatePackageShippingInfoRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tracking_number")]
        [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
        public string TrackingNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置运输服务商 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provider_id")]
        [System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string ShippingProviderId { get; set; } = string.Empty;
    }
}
