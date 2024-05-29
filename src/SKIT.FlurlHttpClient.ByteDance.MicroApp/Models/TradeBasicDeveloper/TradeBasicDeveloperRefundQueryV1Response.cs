namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/refund_query/ 接口的响应。</para>
    /// </summary>
    public class TradeBasicDeveloperRefundQueryV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Refund
                    {
                        public static class Types
                        {
                            public class ItemOrder
                            {
                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                                public string ItemOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                                public int RefundAmount { get; set; }
                            }

                            public class MerchantAuditDetail
                            {
                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_status")]
                                public string AuditStatus { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退款审核类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("need_refund_audit")]
                                [System.Text.Json.Serialization.JsonPropertyName("need_refund_audit")]
                                public int RefundAuditType { get; set; }

                                /// <summary>
                                /// 获取或设置审核的最后期限毫秒级时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_audit_deadline")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_audit_deadline")]
                                public long AuditDeadlineMilliseconds { get; set; }

                                /// <summary>
                                /// 获取或设置不同意退款信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("deny_message")]
                                [System.Text.Json.Serialization.JsonPropertyName("deny_message")]
                                public string? DenyMessage { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开发者退款单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_refund_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
                        public string OutRefundNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
                        public string RefundId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置退款总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_total_amount")]
                        public int RefundTotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_detail")]
                        public Types.ItemOrder[]? ItemOrderList { get; set; }

                        /// <summary>
                        /// 获取或设置退款来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_source")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_source")]
                        public int? RefundSource { get; set; }

                        /// <summary>
                        /// 获取或设置商家审核信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_audit_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_audit_detail")]
                        public Types.MerchantAuditDetail? MerchantAuditDetail { get; set; }

                        /// <summary>
                        /// 获取或设置退款结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string? ResultMessage { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_at")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_at")]
                        public long? CreateTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置退款时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_at")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_at")]
                        public long? RefundTimeMilliseconds { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置退款列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_list")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_list")]
                public Types.Refund[] RefundList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
