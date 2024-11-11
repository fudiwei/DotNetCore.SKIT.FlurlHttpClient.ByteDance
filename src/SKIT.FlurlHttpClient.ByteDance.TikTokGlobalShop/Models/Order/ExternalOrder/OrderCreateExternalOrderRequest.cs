using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/{version}/orders/external_orders 接口的请求。</para>
    /// </summary>
    public class OrderCreateExternalOrderRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Order
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
                                public string LineItemId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置外部订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string ExternalLineItemId { get; set; } = string.Empty;
                            }
                        }

                        /// <summary>
                        /// 获取或设置外部订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ExternalOrderId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置来源平台。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform")]
                        public string Platform { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置订单行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("line_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("line_items")]
                        public IList<Types.LineItem> LineItemList { get; set; } = new List<Types.LineItem>();
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string OrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置外部订单信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_order")]
                [System.Text.Json.Serialization.JsonPropertyName("external_order")]
                public Types.ExternalOrder ExternalOrder { get; set; } = new Types.ExternalOrder();
            }
        }

        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202406</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202406;

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orders")]
        [System.Text.Json.Serialization.JsonPropertyName("orders")]
        public IList<Types.Order> OrderList { get; set; } = new List<Types.Order>();
    }
}
