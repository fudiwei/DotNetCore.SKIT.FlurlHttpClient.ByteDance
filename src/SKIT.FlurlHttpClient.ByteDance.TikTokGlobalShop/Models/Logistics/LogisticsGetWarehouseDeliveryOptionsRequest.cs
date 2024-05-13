namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /logistics/{version}/warehouses/{warehouse_id}/delivery_options 接口的请求。</para>
    /// </summary>
    public class LogisticsGetWarehouseDeliveryOptionsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置仓库 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string WarehouseId { get; set; } = string.Empty;
    }
}
