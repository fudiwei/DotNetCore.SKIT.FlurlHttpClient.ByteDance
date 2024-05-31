namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/query_book 接口的请求。</para>
    /// </summary>
    public class AppsTradeBookQueryBookV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置预约单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string? BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }
    }
}
