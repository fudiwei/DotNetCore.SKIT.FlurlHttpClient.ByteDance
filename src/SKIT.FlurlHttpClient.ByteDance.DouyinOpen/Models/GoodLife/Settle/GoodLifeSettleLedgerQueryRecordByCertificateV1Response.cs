namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/query_record_by_cert 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerQueryRecordByCertificateV1Response : DouyinOpenResponse<GoodLifeSettleLedgerQueryRecordByCertificateV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class LedgerRecord
                    {
                        public static class Types
                        {
                            public class Amount
                            {
                                public static class Types
                                {
                                    public class SettleAmount
                                    {
                                        /// <summary>
                                        /// 获取或设置券原始金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("original")]
                                        [System.Text.Json.Serialization.JsonPropertyName("original")]
                                        public int OriginalAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置用户实付金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pay")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pay")]
                                        public int PayAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置商家营销金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("merchant_ticket")]
                                        [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket")]
                                        public int MerchantTicketAmount { get; set; }
                                    }

                                    public class FundAmount
                                    {
                                        /// <summary>
                                        /// 获取或设置商家货款金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("goods")]
                                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                                        public int GoodsAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置支付手续费（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pay_handling")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pay_handling")]
                                        public int PayHandlingAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置达人佣金（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("talent_commission")]
                                        [System.Text.Json.Serialization.JsonPropertyName("talent_commission")]
                                        public int TalentCommission { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置分账单金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                public Types.SettleAmount SettleAmount { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置分账款项金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fund_amount")]
                                public Types.FundAmount FundAmount { get; set; } = default!;
                            }

                            public class SKU
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置团购名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置团购市场价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("market_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                                public int MarketPrice { get; set; }

                                /// <summary>
                                /// 获取或设置售卖开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sold_start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("sold_start_time")]
                                public long StartTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置分账记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ledger_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ledger_id")]
                        public string LedgerId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_id")]
                        public string VerifyId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                        public string CertificateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_time")]
                        public long VerifyTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置券码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string Code { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置团购 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU SKU { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置分账记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("records")]
                [System.Text.Json.Serialization.JsonPropertyName("records")]
                public Types.LedgerRecord[] LedgerRecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
