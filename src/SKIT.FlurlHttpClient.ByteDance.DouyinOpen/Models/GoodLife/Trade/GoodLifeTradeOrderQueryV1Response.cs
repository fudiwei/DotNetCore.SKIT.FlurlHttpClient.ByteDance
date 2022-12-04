namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/trade/order/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeTradeOrderQueryV1Response : DouyinOpenResponse<GoodLifeTradeOrderQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class Order
                    {
                        public static class Types
                        {
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
