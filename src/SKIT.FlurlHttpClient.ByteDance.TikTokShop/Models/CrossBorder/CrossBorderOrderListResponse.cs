using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/orderList 接口的响应。</para>
    /// </summary>
    public class CrossBorderOrderListResponse : TikTokShopResponse<CrossBorderOrderListResponse.Types.Data>
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

                        internal static class Converters
                        {
                            internal class NewtonsoftJsonAddressConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Address?>
                            {
                            }

                            internal class SystemTextJsonAddressConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.Address?>
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置进出口标志。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ie_flag")]
                        [System.Text.Json.Serialization.JsonPropertyName("ie_flag")]
                        public string? IEFlag { get; set; }

                        /// <summary>
                        /// 获取或设置通关模式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customs_clear_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("customs_clear_type")]
                        public int? CustomsClearType { get; set; }

                        /// <summary>
                        /// 获取或设置申报海关代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customs_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("customs_code")]
                        public string? CustomsCode { get; set; }

                        /// <summary>
                        /// 获取或设置口岸海关代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("port_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("port_code")]
                        public string? PortCode { get; set; }

                        /// <summary>
                        /// 获取或设置仓库编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_code")]
                        public string? WarehouseCode { get; set; }

                        /// <summary>
                        /// 获取或设置服务商仓库类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wh_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("wh_type")]
                        public int? VendorWarehouseType { get; set; }

                        /// <summary>
                        /// 获取或设置服务商仓库编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("scsp_warehouse_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("scsp_warehouse_code")]
                        public string? VendorWarehouseCode { get; set; }

                        /// <summary>
                        /// 获取或设置商品实际成交价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_value")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置运杂费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight")]
                        public int Freight { get; set; }

                        /// <summary>
                        /// 获取或设置非现金抵扣金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public int Discount { get; set; }

                        /// <summary>
                        /// 获取或设置代扣税款（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_total")]
                        public int Tax { get; set; }

                        /// <summary>
                        /// 获取或设置实际支付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actural_paid")]
                        [System.Text.Json.Serialization.JsonPropertyName("actural_paid")]
                        public int ActualPayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置物流保价费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("insured_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("insured_fee")]
                        public int InsuredFee { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电商平台代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ebp_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("ebp_code")]
                        public string? EBPCode { get; set; }

                        /// <summary>
                        /// 获取或设置电商平台名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ebp_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ebp_name")]
                        public string? EBPName { get; set; }

                        /// <summary>
                        /// 获取或设置电商企业备案编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ebc_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("ebc_code")]
                        public string? EBCCode { get; set; }

                        /// <summary>
                        /// 获取或设置电商企业名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ebc_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("ebc_name")]
                        public string? EBCName { get; set; }

                        /// <summary>
                        /// 获取或设置订购人注册号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_reg_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_reg_no")]
                        public string BuyerRegistrationNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订购人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_name")]
                        public string BuyerName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订购人电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_telephone")]
                        public string BuyerPhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订购人证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_id_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_id_type")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int BuyerIdType { get; set; }

                        /// <summary>
                        /// 获取或设置订购人证件号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_id_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_id_number")]
                        public string BuyerIdNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收货人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consignee")]
                        [System.Text.Json.Serialization.JsonPropertyName("consignee")]
                        public string ConsigneeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收货人电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consignee_telephone")]
                        [System.Text.Json.Serialization.JsonPropertyName("consignee_telephone")]
                        public string ConsigneePhoneNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收货人地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consignee_address")]
                        [Newtonsoft.Json.JsonConverter((typeof(Converters.NewtonsoftJsonAddressConverter)))]
                        [System.Text.Json.Serialization.JsonPropertyName("consignee_address")]
                        [System.Text.Json.Serialization.JsonConverter((typeof(Converters.SystemTextJsonAddressConverter)))]
                        public Types.Address ConsigneeAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付企业编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_code")]
                        public string? PayerCode { get; set; }

                        /// <summary>
                        /// 获取或设置支付企业名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_name")]
                        public string? PayerName { get; set; }

                        /// <summary>
                        /// 获取或设置支付企业支付流水号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_transaction_id")]
                        public string? PayerTransactionId { get; set; }

                        /// <summary>
                        /// 获取或设置件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pack_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("pack_no")]
                        public int PackageCount { get; set; }

                        /// <summary>
                        /// 获取或设置订单申报备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("note")]
                        [System.Text.Json.Serialization.JsonPropertyName("note")]
                        public string? Notes { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置支付完成时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        public long PayTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置预售类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_sale_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_sale_type")]
                        public int? PresellType { get; set; }

                        /// <summary>
                        /// 获取或设置发货超时时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exp_ship_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("exp_ship_time")]
                        public long? ExpireShipTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置订单申报类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_declare")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_declare")]
                        public int? OrderDeclareType { get; set; }

                        /// <summary>
                        /// 获取或设置运单申报类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("logistics_declare")]
                        [System.Text.Json.Serialization.JsonPropertyName("logistics_declare")]
                        public int? LogisticsDeclareType { get; set; }

                        /// <summary>
                        /// 获取或设置清单申报类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory_declare")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory_declare")]
                        public int? InventoryDeclareType { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_next")]
                [System.Text.Json.Serialization.JsonPropertyName("has_next")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
