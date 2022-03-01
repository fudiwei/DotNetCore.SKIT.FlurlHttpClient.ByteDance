namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Events
{
    /// <summary>
    /// <para>表示 doudian_trade_TradePartlySellerShip 消息的数据。</para>
    /// <para>REF: https://op.jinritemai.com/docs/message-docs/30/277 </para>
    /// </summary>
    public class TradePartlySellerShipEvent : TikTokShopEvent<TradePartlySellerShipEvent.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Receiver
                    {
                        public static class Types
                        {
                            public class Address
                            {
                                public static class Types
                                {
                                    public class Area
                                    {
                                        /// <summary>
                                        /// 获取或设置地区 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                        public int Id { get; set; }

                                        /// <summary>
                                        /// 获取或设置地区名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置省份信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province")]
                                [System.Text.Json.Serialization.JsonPropertyName("province")]
                                public Types.Area Province { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public Types.Area City { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("town")]
                                [System.Text.Json.Serialization.JsonPropertyName("town")]
                                public Types.Area District { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置街道信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street")]
                                [System.Text.Json.Serialization.JsonPropertyName("street")]
                                public Types.Area? Street { get; set; }

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail")]
                                public string Detail { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置收货人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收货人电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tel")]
                        [System.Text.Json.Serialization.JsonPropertyName("tel")]
                        public string PhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收货地址列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("addr")]
                        [System.Text.Json.Serialization.JsonPropertyName("addr")]
                        public Types.Address[] AddressList { get; set; } = default!;
                    }

                    public class Logistics
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
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置购买数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_num")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int SKUCount { get; set; }

                                /// <summary>
                                /// 获取或设置发货数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipped_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipped_num")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int ShippedCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置快递公司编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("express_company_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("express_company_id")]
                        public string CompanyCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置快递单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_code")]
                        public string LogisticsNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pack_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pack_id")]
                        public string? PackageId { get; set; }

                        /// <summary>
                        /// 获取或设置已发货子订单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipped_order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipped_order_info")]
                        public Types.ShippedOrder[]? ShippedOrderList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商铺订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("p_id")]
                [System.Text.Json.Serialization.JsonPropertyName("p_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string ShopOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("s_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("s_ids")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringArrayConverter))]
                public string[] SKUOrderIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public int ShopId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置业务来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz")]
                [System.Text.Json.Serialization.JsonPropertyName("biz")]
                public int BusinessType { get; set; }

                /// <summary>
                /// 获取或设置物流变更时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置收货人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver_msg")]
                public Types.Receiver Receiver { get; set; } = default!;

                /// <summary>
                /// 获取或设置发货物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_msg")]
                public Types.Logistics Logistics { get; set; } = default!;
            }
        }
    }
}
