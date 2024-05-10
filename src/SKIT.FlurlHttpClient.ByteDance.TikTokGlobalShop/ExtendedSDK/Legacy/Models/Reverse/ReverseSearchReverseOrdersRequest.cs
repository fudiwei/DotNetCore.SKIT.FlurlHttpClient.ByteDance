namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /reverse/reverse_order/list 接口的请求。</para>
    /// </summary>
    public class ReverseSearchReverseOrdersRequest : TikTokShopLegacyRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? ApiVersion { get; set; } = "202307";

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
        /// 获取或设置撤回类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_type")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_type")]
        public int? ReverseType { get; set; }

        /// <summary>
        /// 获取或设置撤回订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_order_status")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_order_status")]
        public int? ReverseOrderStatus { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置撤回订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reverse_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("reverse_order_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public string? ReverseOrderId { get; set; }

        /// <summary>
        /// 获取或设置排序字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_by")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public int? SortBy { get; set; }

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort_type")]
        [System.Text.Json.Serialization.JsonPropertyName("sort_type")]
        public int? SortType { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int PageOffset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int PageSize { get; set; } = 10;
    }
}
