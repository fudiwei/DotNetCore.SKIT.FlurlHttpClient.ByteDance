namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/logisticsAddMultiPack 接口的响应。</para>
    /// </summary>
    public class OrderLogisticsAddMultiplePackageResponse : TikTokShopResponse<OrderLogisticsAddMultiplePackageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Package
                    {
                        public static class Types
                        {
                            public class ShippedOrder
                            {
                                /// <summary>
                                /// 获取或设置子订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipped_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipped_order_id")]
                                public string ShippedOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置待发货数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipped_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipped_num")]
                                public int ShippedCount { get; set; }

                                /// <summary>
                                /// 获取或设置货物 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipped_item_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipped_item_ids")]
                                public string[]? ShippedItemIdList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置待发货的子订单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipped_order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipped_order_info")]
                        public Types.ShippedOrder[] ShippedOrderList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pack_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                        public string LogisticsNumber { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pack_list")]
                [System.Text.Json.Serialization.JsonPropertyName("pack_list")]
                public Types.Package[] PackageList { get; set; } = default!;
            }
        }
    }
}
