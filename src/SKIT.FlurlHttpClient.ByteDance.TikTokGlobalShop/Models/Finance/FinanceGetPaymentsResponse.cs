namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /finance/{version}/payments 接口的响应。</para>
    /// </summary>
    public class FinanceGetPaymentsResponse : TikTokShopResponse<FinanceGetPaymentsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Payment
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? Value { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置付款单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PaymentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置付款单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置支付时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                        public long? PaidTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置付款金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                        public Types.Amount? SettlementAmount { get; set; }

                        /// <summary>
                        /// 获取或设置保留金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reserve_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("reserve_amount")]
                        public Types.Amount? ReserveAmount { get; set; }

                        /// <summary>
                        /// 获取或设置兑换前金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payment_amount_before_exchange")]
                        [System.Text.Json.Serialization.JsonPropertyName("payment_amount_before_exchange")]
                        public Types.Amount? PaymentAmountBeforeExchange { get; set; }

                        /// <summary>
                        /// 获取或设置汇率。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exchange_rate")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("exchange_rate")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? ExchangeRate { get; set; }

                        /// <summary>
                        /// 获取或设置银行账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("bank_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
                        public string? BankAccount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置付款单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payments")]
                [System.Text.Json.Serialization.JsonPropertyName("payments")]
                public Types.Payment[] PaymentList { get; set; } = default!;

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
