namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/search 接口的请求。</para>
    /// </summary>
    public class FulfillmentSearchPackagesRequest : TikTokShopRequest
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
        /// 获取或设置包裹状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_status")]
        [System.Text.Json.Serialization.JsonPropertyName("package_status")]
        public int? PackageStatus { get; set; }

        /// <summary>
        /// 获取或设置是否因运输问题取消。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_because_logistic_issue")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_because_logistic_issue")]
        public int? CancelBecauseLogisticIssue { get; set; }

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
