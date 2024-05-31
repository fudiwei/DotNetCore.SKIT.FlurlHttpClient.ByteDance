using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/book/book_result_callback 接口的请求。</para>
    /// </summary>
    public class AppsTradeBookResultCallbackV2Request : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置预约单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id")]
        public string BookId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置预约结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public int Result { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Message { get; set; }

        /// <summary>
        /// 获取或设置接单方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_type")]
        [System.Text.Json.Serialization.JsonPropertyName("accept_type")]
        public int? AcceptType { get; set; } 
    }
}
