namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/merchant_cancel_book 接口的请求。</para>
    /// </summary>
    public class AppsTradeBookMerchantCancelBookV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置预约单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; } = string.Empty;
    }
}
