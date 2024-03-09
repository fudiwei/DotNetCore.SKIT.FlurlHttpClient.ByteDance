namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/trade/order/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeTradeOrderQueryV1Response : DouyinOpenResponse<GoodLifeTradeOrderQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Order
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("origin_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("origin_amount")]
                                public int OriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商品原价金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_origin_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_origin_amount")]
                                public int ProductOriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置支付优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_discount_amount")]
                                public int PayDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_discount_amount")]
                                public int MerchantDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                                public int PlatformDiscountAmount { get; set; }
                            }

                            public class Certificate
                            {
                                /// <summary>
                                /// 获取或设置券 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("certificate_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                                public string CertificateId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 Item 维度订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_item_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_item_id")]
                                public string? ItemOrderId { get; set; }

                                /// <summary>
                                /// 获取或设置 Item 维度订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_status")]
                                public int? ItemOrderStatus { get; set; }

                                /// <summary>
                                /// 获取或设置 Item 维度订单更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_update_time")]
                                public long? ItemOrderUpdateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                                public int RefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
                                public long? RefundTimestamp { get; set; }
                            }

                            public class Contact
                            {
                                /// <summary>
                                /// 获取或设置姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                                public string PhoneNumber { get; set; } = default!;
                            }

                            public class Delivery
                            {
                                /// <summary>
                                /// 获取或设置流水号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_number")]
                                public string ShopNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置是否为预订单。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_book")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_book")]
                                public bool IsBook { get; set; }

                                /// <summary>
                                /// 获取或设置预计送达时间字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sys_expect_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("sys_expect_time")]
                                public string? ExpectedTimeString { get; set; }

                                /// <summary>
                                /// 获取或设置备注。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("remark")]
                                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                                public string? Remark { get; set; }
                            }

                            public class Merchant
                            {
                                /// <summary>
                                /// 获取或设置商家 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                                public string AccountId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商家名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("account_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("account_name")]
                                public string AccountName { get; set; } = default!;
                            }

                            public class POI
                            {
                                /// <summary>
                                /// 获取或设置门店 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                                public string POIId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置门店名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("poi_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("poi_name")]
                                public string POIName { get; set; } = default!;
                            }

                            public class Receiver
                            {
                                /// <summary>
                                /// 获取或设置省份。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province")]
                                [System.Text.Json.Serialization.JsonPropertyName("province")]
                                public string Province { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city")]
                                [System.Text.Json.Serialization.JsonPropertyName("city")]
                                public string City { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district")]
                                [System.Text.Json.Serialization.JsonPropertyName("district")]
                                public string District { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置街道。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("town")]
                                [System.Text.Json.Serialization.JsonPropertyName("town")]
                                public string Street { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("location_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("location_address")]
                                public string Address { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置纬度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lat")]
                                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                                public decimal? Latitude { get; set; }

                                /// <summary>
                                /// 获取或设置经度。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("lng")]
                                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                                public decimal? Longitude { get; set; }

                                /// <summary>
                                /// 获取或设置脱敏后的收货人姓名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("receiver_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("receiver_name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置脱敏后的收件人手机号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("receiver_phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("receiver_phone")]
                                public string PhoneNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置收件人隐私号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("secret_number")]
                                [System.Text.Json.Serialization.JsonPropertyName("secret_number")]
                                public string? SecretNumber { get; set; }
                            }

                            public class Product
                            {
                                public static class Types
                                {
                                    public class Commodity
                                    {
                                        public static class Types
                                        {
                                            public class Item
                                            {
                                                /// <summary>
                                                /// 获取或设置菜品名。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                                public string Name { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置菜品价格（单位：分）。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("price")]
                                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                                public int Price { get; set; }

                                                /// <summary>
                                                /// 获取或设置菜品数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("count")]
                                                [System.Text.Json.Serialization.JsonPropertyName("count")]
                                                public int Count { get; set; }

                                                /// <summary>
                                                /// 获取或设置菜品单位。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("unit")]
                                                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                                public string? Unit { get; set; }

                                                /// <summary>
                                                /// 获取或设置菜品描述。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("desc")]
                                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                                public string? Description { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置商品组名。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("group_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                                        public string? GroupName { get; set; }

                                        /// <summary>
                                        /// 获取或设置总数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("total_count")]
                                        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                                        public int TotalCount { get; set; }

                                        /// <summary>
                                        /// 获取或设置选择数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("option_count")]
                                        [System.Text.Json.Serialization.JsonPropertyName("option_count")]
                                        public int OptionCount { get; set; }

                                        /// <summary>
                                        /// 获取或设置菜品项列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("items")]
                                        [System.Text.Json.Serialization.JsonPropertyName("items")]
                                        public Types.Item[]? ItemList { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("num")]
                                [System.Text.Json.Serialization.JsonPropertyName("num")]
                                public int Count { get; set; }

                                /// <summary>
                                /// 获取或设置菜品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commodities")]
                                [System.Text.Json.Serialization.JsonPropertyName("commodities")]
                                public Types.Commodity[]? CommodityList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

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
                        /// 获取或设置原始金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_amount")]
                        public int OriginalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        public int PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_discount")]
                        public int PayDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount_info")]
                        public Types.Amount? Amount { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                        public string SKUName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付成功时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        public long? PayTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_order_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_order_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_order_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_order_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string? POIId { get; set; }

                        /// <summary>
                        /// 获取或设置门店信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi")]
                        public Types.POI? POI { get; set; }

                        /// <summary>
                        /// 获取或设置券列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                        public Types.Certificate[] CertificateList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int CertificateCount { get; set; }

                        /// <summary>
                        /// 获取或设置联系人列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contacts")]
                        [System.Text.Json.Serialization.JsonPropertyName("contacts")]
                        public Types.Contact[] ContactList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
                        public Types.Delivery? Delivery { get; set; }

                        /// <summary>
                        /// 获取或设置商家信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_info")]
                        public Types.Merchant? Merchant { get; set; }

                        /// <summary>
                        /// 获取或设置收件人信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receiver_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("receiver_info")]
                        public Types.Receiver? Receiver { get; set; }

                        /// <summary>
                        /// 获取或设置商品列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("products")]
                        [System.Text.Json.Serialization.JsonPropertyName("products")]
                        public Types.Product[]? ProductList { get; set; }
                    }

                    public class Pagination
                    {
                        /// <summary>
                        /// 获取或设置分页页码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_num")]
                        public int PageNumber { get; set; }

                        /// <summary>
                        /// 获取或设置分页每页数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("page_size")]
                        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
                        public int PageSize { get; set; }

                        /// <summary>
                        /// 获取或设置总数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total")]
                        [System.Text.Json.Serialization.JsonPropertyName("total")]
                        public int TotalCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("orders")]
                [System.Text.Json.Serialization.JsonPropertyName("orders")]
                public Types.Order[] OrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
