namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /finance/{version}/statements 接口的响应。</para>
    /// </summary>
    public class FinanceGetStatementsResponse : TikTokShopResponse<FinanceGetStatementsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Statement
                    {
                        /// <summary>
                        /// 获取或设置结算单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string StatementId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statement_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("statement_time")]
                        public long StatementTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置付款单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PaymentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置付款单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_status")]
                        public string PaymentStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SettlementAmount { get; set; }

                        /// <summary>
                        /// 获取或设置收入金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("revenue_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RevenueAmount { get; set; }

                        /// <summary>
                        /// 获取或设置费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置违约金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjustment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("adjustment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AdjustmentAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置结算单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("statements")]
                [System.Text.Json.Serialization.JsonPropertyName("statements")]
                public Types.Statement[] StatementList { get; set; } = default!;

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
