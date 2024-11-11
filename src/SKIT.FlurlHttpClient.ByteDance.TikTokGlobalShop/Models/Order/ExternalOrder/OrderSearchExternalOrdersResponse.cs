namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/{version}/orders/external_order_search 接口的响应。</para>
    /// </summary>
    public class OrderSearchExternalOrdersResponse : TikTokShopResponse<OrderSearchExternalOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Order
                    {
                        public static class Types
                        {
                            public class ExternalOrder : OrderGetExternalOrdersResponse.Types.Data.Types.ExternalOrder
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置外部订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_order")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_order")]
                        public Types.ExternalOrder ExternalOrder { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orders")]
                [System.Text.Json.Serialization.JsonPropertyName("orders")]
                public Types.Order[] OrderList { get; set; } = default!;
            }
        }
    }
}
