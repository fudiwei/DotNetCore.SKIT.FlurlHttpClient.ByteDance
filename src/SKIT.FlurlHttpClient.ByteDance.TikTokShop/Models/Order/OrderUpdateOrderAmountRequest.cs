using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/updateOrderAmount 接口的请求。</para>
    /// </summary>
    public class OrderUpdateOrderAmountRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Detail
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置扣减金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int DiscountAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置改价订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pid")]
        [System.Text.Json.Serialization.JsonPropertyName("pid")]
        public string ParentOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置改价明细信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("update_detail")]
        public Types.Detail Detail { get; set; } = new Types.Detail();
    }
}
