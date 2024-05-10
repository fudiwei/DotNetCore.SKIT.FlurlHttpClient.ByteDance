using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/order_split/verify 接口的请求。</para>
    /// </summary>
    public class FulfillmentVerifyOrderSplitRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id_list")]
        public IList<string> OrderIdList { get; set; } = new List<string>();
    }
}
