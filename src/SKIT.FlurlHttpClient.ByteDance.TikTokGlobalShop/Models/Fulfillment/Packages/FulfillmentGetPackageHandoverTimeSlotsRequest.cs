namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/{version}/packages/{package_id}/handover_time_slots 接口的请求。</para>
    /// </summary>
    public class FulfillmentGetPackageHandoverTimeSlotsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PackageId { get; set; } = string.Empty;
    }
}
