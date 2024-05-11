namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/{version}/orders/search 接口的请求。</para>
    /// </summary>
    public class OrderSearchOrdersRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置创建时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_ge")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_ge")]
        public long? CreateTimestampGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置创建时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_lt")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_lt")]
        public long? CreateTimestampLessThan { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_ge")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_ge")]
        public long? UpdateTimestampGreaterThan { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_lt")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_lt")]
        public long? UpdateTimestampLessThan { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public string? OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置配送方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipping_type")]
        [System.Text.Json.Serialization.JsonPropertyName("shipping_type")]
        public string? ShippingType { get; set; }

        /// <summary>
        /// 获取或设置买家用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_user_id")]
        public string? BuyerUserId { get; set; }

        /// <summary>
        /// 获取或设置买家是否请求取消订单。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_buyer_request_cancel")]
        [System.Text.Json.Serialization.JsonPropertyName("is_buyer_request_cancel")]
        public bool? IsBuyerRequestCancel { get; set; }

        /// <summary>
        /// 获取或设置排序字段。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SortField { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SortOrder { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置分页令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? PageToken { get; set; }
    }
}
