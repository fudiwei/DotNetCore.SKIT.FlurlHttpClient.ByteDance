namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/{version}/packages/search 接口的响应。</para>
    /// </summary>
    public class FulfillmentSearchPackagesResponse : TikTokShopResponse<FulfillmentSearchPackagesResponse.Types.Data>
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
                            public class Order : FulfillmentGetPackageDetailResponse.Types.Data.Types.Order
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置包裹 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PackageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单行 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_line_item_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_line_item_ids")]
                        public string[]? OrderLineItemIdList { get; set; }

                        /// <summary>
                        /// 获取或设置订单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("orders")]
                        [System.Text.Json.Serialization.JsonPropertyName("orders")]
                        public Types.Order[]? OrderList { get; set; }

                        /// <summary>
                        /// 获取或设置包裹状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

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
                        /// 获取或设置物流单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tracking_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("tracking_number")]
                        public string? TrackingNumber { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_id")]
                        public string? ShippingProviderId { get; set; }

                        /// <summary>
                        /// 获取或设置运输服务商名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_provider_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_provider_name")]
                        public string? ShippingProviderName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置包裹列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("packages")]
                [System.Text.Json.Serialization.JsonPropertyName("packages")]
                public Types.Package[] PackageList { get; set; } = default!;

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
