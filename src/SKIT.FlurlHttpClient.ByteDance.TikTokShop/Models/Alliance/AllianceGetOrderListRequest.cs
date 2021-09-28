using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /alliance/getOrderList 接口的请求。</para>
    /// </summary>
    public class AllianceGetOrderListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_ids")]
        public IList<string> OrderIdList { get; set; } = new List<string>();
    }
}
