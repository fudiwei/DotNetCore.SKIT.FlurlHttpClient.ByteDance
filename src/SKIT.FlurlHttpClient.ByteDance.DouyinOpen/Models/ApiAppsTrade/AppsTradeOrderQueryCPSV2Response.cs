namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/order/query_cps 接口的响应。</para>
    /// </summary>
    public class AppsTradeOrderQueryCPSV2Response : DouyinOpenResponse<AppsTradeOrderQueryCPSV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Payment
                    {
                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public string OrderStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支付总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
                        public int TotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置收款商户号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_uid")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_uid")]
                        public string? MerchantId { get; set; }

                        /// <summary>
                        /// 获取或设置支付渠道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_channel")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_channel")]
                        public int? PayChannel { get; set; }

                        /// <summary>
                        /// 获取或设置渠道支付单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("channel_pay_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("channel_pay_id")]
                        public string? ChannelPayId { get; set; }

                        /// <summary>
                        /// 获取或设置支付时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        public string? PayTimeString { get; set; }

                        /// <summary>
                        /// 获取或设置自定义字段。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cp_extra")]
                        [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
                        public string? Extra { get; set; }

                        /// <summary>
                        /// 获取或设置结果信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("message")]
                        [System.Text.Json.Serialization.JsonPropertyName("message")]
                        public string? ResultMessage { get; set; }
                    }

                    public class CPS
                    {
                        public static class Types
                        {
                            public class CPSItem
                            {
                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                                public string ItemOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置售价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sell_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sell_amount")]
                                public int SellAmount { get; set; }

                                /// <summary>
                                /// 获取或设置分佣类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("source_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("source_type")]
                                public int SourceType { get; set; }

                                /// <summary>
                                /// 获取或设置订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_amount")]
                                public int CommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置分佣比例（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                                public int CommissionRate { get; set; }

                                /// <summary>
                                /// 获取或设置达人抖音号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_user_douyinid")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_user_douyinid")]
                                public string CommissionUserDouyinId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置达人昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_user_nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_user_nickname")]
                                public string CommissionUserNickname { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置任务 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("task_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                                public string TaskId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置短视频或直播间 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_id")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ItemId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置佣金总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_commission_amount")]
                        public int TotalCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 CPS 信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cps_item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("cps_item_list")]
                        public Types.CPSItem[] CPSItemList { get; set; } = default!;
                    }

                    public class Refund
                    {
                        public static class Types
                        {
                            public class RefundItem
                            {
                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                                public string ItemOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置开发者退款单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("out_refund_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
                                public string OutRefundNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                                public int RefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                                public string RefundStatus { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置退款时间毫秒级时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_at")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_at")]
                                public long? RefundTimeMilliseconds { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置退款总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_refund_amount")]
                        public int TotalRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_items")]
                        public Types.RefundItem[] RefundItemList { get; set; } = default!;
                    }

                    public class Delivery
                    {
                        public static class Types
                        {
                            public class DeliveryItem
                            {
                                /// <summary>
                                /// 获取或设置商品单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                                public string ItemOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置核销金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_amount")]
                                public int DeliveryAmount { get; set; }

                                /// <summary>
                                /// 获取或设置核销状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_status")]
                                public string Deliverytatus { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置核销时间毫秒级时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_at")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_at")]
                                public long? DeliveryTimeMilliseconds { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置核销总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_delivery_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_delivery_amount")]
                        public int TotalDeliveryAmount { get; set; }

                        /// <summary>
                        /// 获取或设置核销信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_items")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_items")]
                        public Types.DeliveryItem[] DeliveryItemList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置开发者订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string OutOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_info")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_info")]
                public Types.Payment Payment { get; set; } = default!;

                /// <summary>
                /// 获取或设置 CPS 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cps_info")]
                [System.Text.Json.Serialization.JsonPropertyName("cps_info")]
                public Types.CPS CPS { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_info")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_info")]
                public Types.Refund? Refund { get; set; }

                /// <summary>
                /// 获取或设置核销信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_info")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
                public Types.Delivery? Delivery { get; set; }
            }
        }
    }
}
