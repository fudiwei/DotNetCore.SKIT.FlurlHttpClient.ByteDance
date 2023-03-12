namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /finance/settlements/search 接口的请求。</para>
    /// </summary>
    public class FinanceSettlementsSearchRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置请求时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_time_from")]
        [System.Text.Json.Serialization.JsonPropertyName("request_time_from")]
        public long? RequestTimestampFrom { get; set; }

        /// <summary>
        /// 获取或设置请求时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_time_to")]
        [System.Text.Json.Serialization.JsonPropertyName("request_time_to")]
        public long? RequestTimestampTo { get; set; }

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
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 20;
    }
}
