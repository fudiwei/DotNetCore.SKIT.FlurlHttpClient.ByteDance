namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /finance/transactions/search 接口的响应。</para>
    /// </summary>
    public class FinanceSearchTransactionsResponse : TikTokShopResponse<FinanceSearchTransactionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Transaction
                    {
                        /// <summary>
                        /// 获取或设置交易类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_type")]
                        public int TransactionType { get; set; }

                        /// <summary>
                        /// 获取或设置交易状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_status")]
                        public int TransactionStatus { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualDecimalReadOnlyConverter))]
                        public decimal Amount { get; set; }

                        /// <summary>
                        /// 获取或设置交易时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_time")]
                        public long TransactionTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置交易列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_list")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_list")]
                public Types.Transaction[] TransactionList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("more")]
                [System.Text.Json.Serialization.JsonPropertyName("more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
