namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/returns/search 接口的响应。</para>
    /// </summary>
    public class ReturnRefundSearchReturnsResponse : TikTokShopResponse<ReturnRefundSearchReturnsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Return
                    {
                        public static class Types
                        {
                            public class RefundAmount : ReturnRefundSearchCancellationsResponse.Types.Data.Types.Cancellation.Types.RefundAmount
                            {
                            }

                            public class DiscountAmount
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_platform_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_platform_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ProductPlatformDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置商品卖家优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_seller_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_seller_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ProductSellerDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费用平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_platform_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_platform_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeePlatformDiscount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费用卖家优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_seller_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_seller_discount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeSellerDiscount { get; set; }
                            }

                            public class ShippingFeeAmount
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置平台承担的退款运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_paid_return_shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_paid_return_shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformPaidReturnShippingFee { get; set; }

                                /// <summary>
                                /// 获取或设置卖家承担的退款运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_paid_return_shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_paid_return_shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SellerPaidReturnShippingFee { get; set; }

                                /// <summary>
                                /// 获取或设置买家承担的退款运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("buyer_paid_return_shipping_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("buyer_paid_return_shipping_fee")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal BuyerPaidReturnShippingFee { get; set; }
                            }

                            public class SellerActionResponse : ReturnRefundSearchCancellationsResponse.Types.Data.Types.Cancellation.Types.SellerActionResponse
                            {
                            }

                            public class ReturnLineItem
                            {
                                public static class Types
                                {
                                    public class Image : ReturnRefundSearchCancellationsResponse.Types.Data.Types.Cancellation.Types.CancelLineItem.Types.Image
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置退货订单行 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_line_item_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_line_item_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ReturnLineItemId { get; set; } = default!;

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
                        /// 获取或设置退货 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ReturnId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_type")]
                        public string Type { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_reason")]
                        public string ReturnReason { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货原因文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_reason_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_reason_text")]
                        public string ReturnReasonText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置仲裁状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("arbitration_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("arbitration_status")]
                        public string ArbitrationStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货发起人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("role")]
                        [System.Text.Json.Serialization.JsonPropertyName("role")]
                        public string ReturnRole { get; set; } = default!;

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
                        /// 获取或设置运输类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipment_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipment_type")]
                        public string ShipmentType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置交接方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("handover_method")]
                        [System.Text.Json.Serialization.JsonPropertyName("handover_method")]
                        public string HandoverMethod { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退货物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_tracking_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_tracking_number")]
                        public string? ReturnTrackingNumber { get; set; }

                        /// <summary>
                        /// 获取或设置退货运输服务商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_provider_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_provider_id")]
                        public string? ReturnProviderId { get; set; }

                        /// <summary>
                        /// 获取或设置退货运输服务商名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_provider_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_provider_name")]
                        public string? ReturnProviderName { get; set; }

                        /// <summary>
                        /// 获取或设置前退货 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pre_return_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("pre_return_id")]
                        public string? PreviousReturnId { get; set; }

                        /// <summary>
                        /// 获取或设置后退货 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("next_return_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("next_return_id")]
                        public string? NextReturnId { get; set; }

                        /// <summary>
                        /// 获取或设置买家是否可保留货物。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_buyer_keep_item")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_buyer_keep_item")]
                        public bool CanBuyerKeepItem { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                        public Types.RefundAmount RefundAmount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠金额信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public Types.DiscountAmount[]? DiscountAmountList { get; set; }

                        /// <summary>
                        /// 获取或设置运费金额信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_amount")]
                        public Types.ShippingFeeAmount[]? ShippingFeeAmountList { get; set; }

                        /// <summary>
                        /// 获取或设置卖家后续操作列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_next_action_response")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_next_action_response")]
                        public Types.SellerActionResponse[]? SellerNextActionResponseList { get; set; }

                        /// <summary>
                        /// 获取或设置退货订单行列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_line_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_line_items")]
                        public Types.ReturnLineItem[]? ReturnLineItemList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置退货列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("return_orders")]
                [System.Text.Json.Serialization.JsonPropertyName("return_orders")]
                public Types.Return[] ReturnList { get; set; } = default!;

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
