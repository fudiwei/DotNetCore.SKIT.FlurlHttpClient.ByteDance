using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/settle 接口的响应。</para>
    /// </summary>
    public class OrderSettleResponse : DouyinShopResponse<OrderSettleResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Bill
                    {
                        public static class Types
                        {
                            public class Order
                            {
                                /// <summary>
                                /// 获取或设置店铺订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
                                public string ShopOrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置子订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                public string OrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置订单创建时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset CreateTime { get; set; }

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置阶段单号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_order_no")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_order_no")]
                                public string? PhaseOrderNumber { get; set; }

                                /// <summary>
                                /// 获取或设置阶段数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_cnt")]
                                public int PhaseCount { get; set; }

                                /// <summary>
                                /// 获取或设置阶段 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phase_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("phase_id")]
                                public int PhaseId { get; set; }
                            }

                            public class Settlement
                            {
                                /// <summary>
                                /// 获取或设置结算时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settle_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset SettleTime { get; set; }

                                /// <summary>
                                /// 获取或设置结算账户类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int PayType { get; set; }

                                /// <summary>
                                /// 获取或设置业务类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flow_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int FlowType { get; set; }

                                /// <summary>
                                /// 获取或设置实际结算金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settle_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                                public int SettleAmount { get; set; }
                            }

                            public class Income
                            {
                                /// <summary>
                                /// 获取或设置实际支付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                                public int PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台券补贴金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_coupon")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_coupon")]
                                public int PlatformCouponAmount { get; set; }

                                /// <summary>
                                /// 获取或设置支付优惠金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_promotion_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_promotion_amount")]
                                public int PayPromotionAmount { get; set; }
                            }

                            public class Outcome
                            {
                                /// <summary>
                                /// 获取或设置订单退款金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_refund")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_refund")]
                                public int OrderRefund { get; set; }

                                /// <summary>
                                /// 获取或设置平台服务费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_service_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_service_fee")]
                                public int PlatformServiceFee { get; set; }

                                /// <summary>
                                /// 获取或设置达人佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_commission")]
                                public int AuthorCommission { get; set; }

                                /// <summary>
                                /// 获取或设置“好好学习”渠道费用（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("good_learn_channel_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("good_learn_channel_fee")]
                                public int GoodLearnChannelFee { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
                        public Types.Order Order { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
                        public Types.Settlement Settlement { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置收入信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("income_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("income_info")]
                        public Types.Income? Income { get; set; }

                        /// <summary>
                        /// 获取或设置支出信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outcome_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("outcome_info")]
                        public Types.Outcome? Outcome { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置账单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Bill[] BillList { get; set; } = default!;

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
