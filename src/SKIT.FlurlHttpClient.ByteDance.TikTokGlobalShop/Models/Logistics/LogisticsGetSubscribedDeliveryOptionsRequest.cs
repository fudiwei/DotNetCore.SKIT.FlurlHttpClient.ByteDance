using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /logistics/get_subscribed_deliveryoptions 接口的请求。</para>
    /// </summary>
    public class LogisticsGetSubscribedDeliveryOptionsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置仓库 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warehouse_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id_list")]
        public IList<string> WarehouseIdList { get; set; } = new List<string>();
    }
}
