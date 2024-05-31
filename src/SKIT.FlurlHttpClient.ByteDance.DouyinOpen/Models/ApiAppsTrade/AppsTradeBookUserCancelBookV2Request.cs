using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/user_cancel_book 接口的请求。</para>
    /// </summary>
    public class AppsTradeBookUserCancelBookV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置预约单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置取消原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public IList<string> CancelReasonList { get; set; } = new List<string>();
    }
}
