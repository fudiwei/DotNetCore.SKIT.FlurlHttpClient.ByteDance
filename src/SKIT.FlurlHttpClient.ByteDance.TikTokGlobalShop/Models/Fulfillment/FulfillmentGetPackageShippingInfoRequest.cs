namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/shipping_info 接口的请求。</para>
    /// </summary>
    public class FulfillmentGetPackageShippingInfoRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PackageId { get; set; } = string.Empty;
    }
}
