namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/{version}/delivery_options/{delivery_option_id}/shipping_providers 接口的请求。</para>
    /// </summary>
    public class LogisticsGetDeliveryOptionShippingProvidersRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置配送方式 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DeliveryOptionId { get; set; } = string.Empty;
    }
}
