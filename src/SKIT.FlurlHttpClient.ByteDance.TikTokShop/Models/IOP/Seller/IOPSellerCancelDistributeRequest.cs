using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerCancleDistribute 接口的请求。</para>
    /// </summary>
    public class IOPSellerCancelDistributeRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置代打订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_order_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_order_ids")]
        public IList<string> DistributeOrderIdList { get; set; } = new List<string>();
    }
}
