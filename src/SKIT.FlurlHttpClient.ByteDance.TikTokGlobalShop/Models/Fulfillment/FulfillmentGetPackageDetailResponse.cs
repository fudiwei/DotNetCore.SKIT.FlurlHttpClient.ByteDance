namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fulfillment/detail 接口的响应。</para>
    /// </summary>
    public class FulfillmentGetPackageDetailResponse : TikTokShopResponse<FulfillmentGetPackageDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class OrderInfo
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                                public string SKUName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_image")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_image")]
                                public string SKUImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置包裹 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_id")]
                [System.Text.Json.Serialization.JsonPropertyName("package_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string PackageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置包裹状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_status")]
                [System.Text.Json.Serialization.JsonPropertyName("package_status")]
                public int PackageStatus { get; set; }

                /// <summary>
                /// 获取或设置包裹冻结状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_freeze_status")]
                [System.Text.Json.Serialization.JsonPropertyName("package_freeze_status")]
                public int PackageFreezeStatus { get; set; }

                /// <summary>
                /// 获取或设置订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_info_list")]
                public Types.OrderInfo[] OrderInfoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单项 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_line_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_line_id_list")]
                public string[]? OrderLineIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置拆/合包标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sc_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("sc_tag")]
                public int SplitOrCombineTag { get; set; }

                /// <summary>
                /// 获取或设置打印标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("print_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("print_tag")]
                public int PrintTag { get; set; }

                /// <summary>
                /// 获取或设置 SKU 标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_tag")]
                public int SKUTag { get; set; }

                /// <summary>
                /// 获取或设置备注标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("note_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("note_tag")]
                public int NoteTag { get; set; }

                /// <summary>
                /// 获取或设置配送方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_option")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_option")]
                public int DeliveryOption { get; set; }

                /// <summary>
                /// 获取或设置运输服务商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                public string ShippingProviderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置运输服务商名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shipping_provider")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_provider")]
                public string ShippingProviderName { get; set; } = default!;

                /// <summary>
                /// 获取或设置物流单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tracking_number")]
                [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                public string TrackingNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置提货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_up_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_up_type")]
                public int PickupType { get; set; }

                /// <summary>
                /// 获取或设置上门提货开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_up_start_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_up_start_time")]
                public long? PickupStartTimestamp { get; set; }

                /// <summary>
                /// 获取或设置上门提货结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_up_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_up_end_time")]
                public long? PickupEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置是否因运输问题取消。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_because_logistic_issue")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_because_logistic_issue")]
                public int? CancelBecauseLogisticIssue { get; set; }

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
            }
        }
    }
}
