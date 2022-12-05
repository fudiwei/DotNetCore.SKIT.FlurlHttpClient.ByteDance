using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/settle/ledger/detailed_query 接口的响应。</para>
    /// </summary>
    public class GoodLifeSettleLedgerDetailedQueryV1Response : DouyinOpenResponse<GoodLifeSettleLedgerDetailedQueryV1Response.Types.Data>
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
                                /// <summary>
                                /// 获取或设置券原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("original")]
                                [System.Text.Json.Serialization.JsonPropertyName("original")]
                                public int OriginalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置券原始金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置支付渠道优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_discount")]
                                public int PayDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置实际保费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_insured")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_insured")]
                                public int ActualInsuredAmount { get; set; }

                                /// <summary>
                                /// 获取或设置券实付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("coupon_pay")]
                                [System.Text.Json.Serialization.JsonPropertyName("coupon_pay")]
                                public int CouponPayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家货款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods")]
                                public int GoodsAmount { get; set; }

                                /// <summary>
                                /// 获取或设置实际参与分账的平台优惠券金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ledger_platform_ticket")]
                                [System.Text.Json.Serialization.JsonPropertyName("ledger_platform_ticket")]
                                public int LedgerPlatformTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置参与分账的总金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ledger_total")]
                                [System.Text.Json.Serialization.JsonPropertyName("ledger_total")]
                                public int LedgerTotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("merchant_ticket")]
                                [System.Text.Json.Serialization.JsonPropertyName("merchant_ticket")]
                                public int MerchantTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家营销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_ticket")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_ticket")]
                                public int PlatformTicketAmount { get; set; }

                                /// <summary>
                                /// 获取或设置机构佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("institution_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("institution_commission")]
                                public int InstitutionCommission { get; set; }

                                /// <summary>
                                /// 获取或设置达人佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("talent_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("talent_commission")]
                                public int TalentCommission { get; set; }

                                /// <summary>
                                /// 获取或设置服务商分佣总金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_agent_merchant")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_agent_merchant")]
                                public int AgentMerchantTotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商家平台服务费总金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_merchant_platform_service")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_merchant_platform_service")]
                                public int MerchantPlatformServiceTotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置代运营服务商总金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_operation_agent")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_operation_agent")]
                                public int OperationAgentTotalAmount { get; set; }
                            }

                            public class Certificate
                            {
                                /// <summary>
                                /// 获取或设置券 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("certificate_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("certificate_id")]
                                public string CertificateId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置券码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public string Code { get; set; } = default!;
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
                                [Newtonsoft.Json.JsonProperty("group_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("group_name")]
                                public string Title { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售卖开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sold_start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("sold_start_time")]
                                public long StartTimestamp { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商家 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_id")]
                        public string AccountId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置券信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate")]
                        public Types.Certificate Certificate { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置数据唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("poi_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                        public string POIId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分账记录 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ledger_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ledger_id")]
                        public string LedgerId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 Item 维度订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                        public string? ItemOrderId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 维度订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_order_id")]
                        public string? SKUOrderId { get; set; }

                        /// <summary>
                        /// 获取或设置分账状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置分账成功时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ledger_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("ledger_time")]
                        public long LedgerTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置金额信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public Types.Amount Amount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置团购 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods")]
                        public Types.SKU SKU { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单参数字典。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_attrribute")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_attrribute")]
                        public IDictionary<string, string>? OrderAttributeMap { get; set; }

                        /// <summary>
                        /// 获取或设置发票月账单的 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receipt_bill_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("receipt_bill_key")]
                        public string? ReceiptBillKey { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置分账记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ledger_records")]
                [System.Text.Json.Serialization.JsonPropertyName("ledger_records")]
                public Types.LedgerRecord[] LedgerRecordList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public string? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
