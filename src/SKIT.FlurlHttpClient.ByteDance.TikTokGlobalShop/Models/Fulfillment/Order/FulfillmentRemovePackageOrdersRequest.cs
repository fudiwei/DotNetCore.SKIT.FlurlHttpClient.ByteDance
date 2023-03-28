using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/package/remove 接口的请求。</para>
    /// </summary>
    public class FulfillmentRemovePackageOrdersRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置包裹 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_id")]
        [System.Text.Json.Serialization.JsonPropertyName("package_id")]
        public string PackageId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<string> OrderIdList { get; set; } = new List<string>();
    }
}
