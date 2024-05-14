namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/cancellations/search 接口的响应。</para>
    /// </summary>
    public class ReturnRefundSearchCancellationsResponse : TikTokShopResponse<ReturnRefundSearchCancellationsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Cancellation
                    {
                        public static class Types
                        {
                            public class RefundAmount
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退款总金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_total")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_total")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundTotal { get; set; }

                                /// <summary>
                                /// 获取或设置退款小计金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_subtotal")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_subtotal")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundSubtotal { get; set; }

                                /// <summary>
                                /// 获取或设置退款运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundShippingFee { get; set; }

                                /// <summary>
                                /// 获取或设置退税金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_tax")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_tax")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundTax { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFee { get; set; }
                            }

                            public class SellerActionResponse
                            {
                                /// <summary>
                                /// 获取或设置操作类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("action")]
                                [System.Text.Json.Serialization.JsonPropertyName("action")]
                                public string Action { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置截止时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deadline")]
                                [System.Text.Json.Serialization.JsonPropertyName("deadline")]
                                public long DeadlineTimestamp { get; set; }
                            }

                            public class CancelLineItem
                            {
                                public static class Types
                                {
                                    public class Image
                                    {
                                        /// <summary>
                                        /// 获取或设置图片 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                        public string Url { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置图片宽度（单位：像素）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("width")]
                                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                                        public int Width { get; set; }

                                        /// <summary>
                                        /// 获取或设置图片高度（单位：像素）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("height")]
                                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                                        public int Height { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置取消订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cancel_line_item_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("cancel_line_item_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string CancelLineItemId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_line_item_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_line_item_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string? OrderlLineItemId { get; set; }

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品图片信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_image")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_image")]
                                public Types.Image? ProductImage { get; set; }

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
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置退款金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                                public RefundAmount RefundAmount { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置取消 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CancelId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取消类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取消状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取消原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
                        public string CancelReason { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取消原因文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_reason_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason_text")]
                        public string CancelReasonText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取消发起人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("role")]
                        [System.Text.Json.Serialization.JsonPropertyName("role")]
                        public string CancelRole { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        public Types.RefundAmount RefundAmount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家后续操作列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_next_action_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_next_action_response")]
                        public Types.SellerActionResponse[]? SellerNextActionResponseList { get; set; }

                        /// <summary>
                        /// 获取或设置取消订单行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_line_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_line_items")]
                        public Types.CancelLineItem[]? CancelLineItemList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置取消列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancellations")]
                [System.Text.Json.Serialization.JsonPropertyName("cancellations")]
                public Types.Cancellation[] CancellationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
