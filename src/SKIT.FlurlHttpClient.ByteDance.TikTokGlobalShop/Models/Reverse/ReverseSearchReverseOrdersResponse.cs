namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /reverse/reverse_order/list 接口的响应。</para>
    /// </summary>
    public class ReverseSearchReverseOrdersResponse : TikTokShopResponse<ReverseSearchReverseOrdersResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ReverseOrder
                    {
                        public static class Types
                        {
                            public class ReturnSKU
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_product_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                                public string SKUName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_quantity")]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_images")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_images")]
                                public string? ImageUrl { get; set; }
                            }

                            public class ReverseRecord
                            {
                                /// <summary>
                                /// 获取或设置描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("description")]
                                [System.Text.Json.Serialization.JsonPropertyName("description")]
                                public string? Description { get; set; }

                                /// <summary>
                                /// 获取或设置撤回原因。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reason_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("reason_text")]
                                public string? ReverseReason { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置补充材料留言。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("additional_message")]
                                [System.Text.Json.Serialization.JsonPropertyName("additional_message")]
                                public string? AdditionalMessage { get; set; }

                                /// <summary>
                                /// 获取或设置补充材料图片 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("additional_image_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("additional_image_list")]
                                public string[]? AdditionalImageUrlList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置撤回订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string ReverseOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置撤回类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_type")]
                        public int ReverseType { get; set; }

                        /// <summary>
                        /// 获取或设置撤回订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_status_value")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_status_value")]
                        public int ReverseOrderStatus { get; set; }

                        /// <summary>
                        /// 获取或设置撤回记录列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_record_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_record_list")]
                        public Types.ReverseRecord[] ReverseRecordList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_type")]
                        public int? ReturnType { get; set; }

                        /// <summary>
                        /// 获取或设置退货原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_reason")]
                        public string? ReturnReason { get; set; }

                        /// <summary>
                        /// 获取或设置退货 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_item_list")]
                        public Types.ReturnSKU[]? ReturnSKUList { get; set; }

                        /// <summary>
                        /// 获取或设置退货物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_tracking_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_tracking_id")]
                        public string? ReturnTrackingNumber { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_total")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                        public decimal RefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置申请时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_request_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_request_time")]
                        public long RequestTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reverse_update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("reverse_update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置撤回订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reverse_list")]
                [System.Text.Json.Serialization.JsonPropertyName("reverse_list")]
                public Types.ReverseOrder[] ReverseOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("more")]
                [System.Text.Json.Serialization.JsonPropertyName("more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
