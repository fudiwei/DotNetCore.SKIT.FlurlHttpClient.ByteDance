using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /finance/transactions/search 接口的请求。</para>
    /// </summary>
    public class FinanceSearchTransactionsRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置结算时间范围起始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_time_from")]
        [System.Text.Json.Serialization.JsonPropertyName("request_time_from")]
        public long? SettlementTimestampFrom { get; set; }

        /// <summary>
        /// 获取或设置结算时间范围截止时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_time_to")]
        [System.Text.Json.Serialization.JsonPropertyName("request_time_to")]
        public long? SettlementTimestampTo { get; set; }

        /// <summary>
        /// 获取或设置交易类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_type")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_type")]
        public IList<int> TransactionTypeList { get; set; } = new List<int>();

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
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; } = 10;
    }
}
