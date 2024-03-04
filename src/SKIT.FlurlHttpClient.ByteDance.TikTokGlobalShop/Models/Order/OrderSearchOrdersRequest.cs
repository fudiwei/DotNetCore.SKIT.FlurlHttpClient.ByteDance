namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orders/search 接口的请求。</para>
    /// </summary>
    public class OrderSearchOrdersRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置创建时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_from")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_from")]
        public long? CreateTimestampFrom { get; set; }

        /// <summary>
        /// 获取或设置创建时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_to")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_to")]
        public long? CreateTimestampTo { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_from")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_from")]
        public long? UpdateTimestampFrom { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_to")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_to")]
        public long? UpdateTimestampTo { get; set; }

        /// <summary>
        /// 获取或设置订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// 获取或设置配送方式类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_option_type")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_type")]
        public int? DeliveryOptionType { get; set; }

        /// <summary>
        /// 获取或设置买家用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_uid")]
        public string? BuyerUserId { get; set; }

        /// <summary>
        /// 获取或设置排序字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public string? SortBy { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_type")]
        public int? SortType { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? PageCursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
