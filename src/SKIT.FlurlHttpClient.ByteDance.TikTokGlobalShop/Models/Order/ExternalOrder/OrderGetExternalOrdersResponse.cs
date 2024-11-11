namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /order/{version}/orders/{order_id}/external_orders 接口的响应。</para>
    /// </summary>
    public class OrderGetExternalOrdersResponse : TikTokShopResponse<OrderGetExternalOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ExternalOrder
                    {
                        public static class Types
                        {
                            public class LineItem
                            {
                                /// <summary>
                                /// 获取或设置订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("origin_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("origin_id")]
                                public string LineItemId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置外部订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string ExternalLineItemId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置外部订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ExternalOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置来源平台。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform")]
                        public string Platform { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("line_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("line_items")]
                        public Types.LineItem[] LineItemList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置外部订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_orders")]
                [System.Text.Json.Serialization.JsonPropertyName("external_orders")]
                public Types.ExternalOrder[] ExternalOrderList { get; set; } = default!;
            }
        }
    }
}
