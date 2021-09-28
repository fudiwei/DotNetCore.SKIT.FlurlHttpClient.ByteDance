namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /address/list 接口的请求。</para>
    /// </summary>
    public class AddressListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_no")]
        [System.Text.Json.Serialization.JsonPropertyName("page_no")]
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 获取或设置排序方式。
        /// <para>默认值：desc</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by")]
        [System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string SortBy { get; set; } = "desc";

        /// <summary>
        /// 获取或设置排序字段。
        /// <para>默认值：create_time</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_field")]
        [System.Text.Json.Serialization.JsonPropertyName("order_field")]
        public string SortField { get; set; } = "create_time";
    }
}
