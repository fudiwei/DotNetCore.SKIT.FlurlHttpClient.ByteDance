using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerDistribute 接口的请求。</para>
    /// </summary>
    public class IOPSellerDistributeRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class DistributeOrder
            {
                /// <summary>
                /// 获取或设置要分配的厂商的店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_shop_id")]
                public long SupplierShopId { get; set; }

                /// <summary>
                /// 获取或设置代打订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("distr_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
                public string DistributeOrderId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置待分配的代打订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distribute_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("distribute_order_list")]
        public IList<Types.DistributeOrder> DistributeOrderList { get; set; } = new List<Types.DistributeOrder>();
    }
}
