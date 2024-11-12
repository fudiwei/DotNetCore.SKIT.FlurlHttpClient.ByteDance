namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fbt/{version}/inbound_orders 接口的响应。</para>
    /// </summary>
    public class FBTGetInboundOrdersResponse : TikTokShopResponse<FBTGetInboundOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class InboundOrder
                    {
                        public static class Types
                        {
                            public class Merchant
                            {
                                /// <summary>
                                /// 获取或设置商户 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string MerchantId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }

                            public class Warehouse
                            {
                                /// <summary>
                                /// 获取或设置 FBT 仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fbt_warehouse_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("fbt_warehouse_id")]
                                public string FBTWarehouseId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置仓库 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("warehouse_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("warehouse_ids")]
                                public string[] WarehouseIdList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;
                            }

                            public class PlannedGoods
                            {
                                /// <summary>
                                /// 获取或设置货物 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string GoodsId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商家自定义货物标识符。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reference_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("reference_code")]
                                public string ReferenceCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置货物名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_ids")]
                                public string[] SKUIdList { get; set; } = default!;
                            }

                            public class ReceivedBatch
                            {
                                /// <summary>
                                /// 获取或设置批次 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string BatchId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置货物 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                                public string GoodsId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置正常货物数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("normal_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("normal_quantity")]
                                public int NormalQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置缺陷数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("defective_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("defective_quantity")]
                                public int DefectiveQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置总数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
                                public int TotalQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置商品 ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
                                public string[] ProductIdList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_ids")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_ids")]
                                public string[] SKUIdList { get; set; } = default!;
                            }

                            public class OperationLog
                            {
                                /// <summary>
                                /// 获取或设置入库单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                                public string OrderStatus { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置操作时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("operate_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("operate_time")]
                                public long OperateTimestamp { get; set; }
                            }

                            public class Carrier
                            {
                                /// <summary>
                                /// 获取或设置运输商名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("carrier_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("carrier_name")]
                                public string CarrierName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置物流单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tracking_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                                public string TrackingNumber { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置入库单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string InboundOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant")]
                        public Types.Merchant Merchant { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置运输时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ship_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("ship_time")]
                        public long ShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置预计到达时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("expect_arrive_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("expect_arrive_time")]
                        public long ExpectArriveTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置实际到达时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_arrive_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_arrive_time")]
                        public long ActualArriveTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置仓库信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse")]
                        public Types.Warehouse Warehouse { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置计划货物列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("planned_goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("planned_goods")]
                        public Types.PlannedGoods[] PlannedGoodsList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置接收批次列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("received_batches")]
                        [System.Text.Json.Serialization.JsonPropertyName("received_batches")]
                        public Types.ReceivedBatch[] ReceivedBatchList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置操作日志列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_operation_logs")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_operation_logs")]
                        public Types.OperationLog[] OperationLogList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置运输商列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("carriers")]
                        [System.Text.Json.Serialization.JsonPropertyName("carriers")]
                        public Types.Carrier[] CarrierList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置入库单列表 。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inbound_orders")]
                [System.Text.Json.Serialization.JsonPropertyName("inbound_orders")]
                public Types.InboundOrder[] InboundOrderList { get; set; } = default!;
            }
        }
    }
}
