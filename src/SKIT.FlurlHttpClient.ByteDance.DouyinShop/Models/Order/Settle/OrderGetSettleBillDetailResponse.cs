using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/getSettleBillDetail 接口的响应。</para>
    /// </summary>
    public class OrderGetSettleBillDetailResponse : DouyinShopResponse<OrderGetSettleBillDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Bill
                    {
                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ShopId { get; set; }

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
                        /// 获取或设置下单时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("order_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset OrderTime { get; set; }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_count")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置结算单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("request_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("request_no")]
                        public string RequestNumber { get; set; } = default!;

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

                        /// <summary>
                        /// 获取或设置结算账户类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trade_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int TradeType { get; set; }

                        /// <summary>
                        /// 获取或设置结算状态描述描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trade_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("trade_type_desc")]
                        public string TradeTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算账户类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayType { get; set; }

                        /// <summary>
                        /// 获取或设置结算账户类型描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_type_desc")]
                        public string PayTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置业务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flow_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int FlowType { get; set; }

                        /// <summary>
                        /// 获取或设置业务类型描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flow_type_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("flow_type_desc")]
                        public string FlowTypeDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset SettleTime { get; set; }

                        /// <summary>
                        /// 获取或设置总收入（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_income")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_income")]
                        public int TotalIncome { get; set; }

                        /// <summary>
                        /// 获取或设置总支出（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_outcome")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_outcome")]
                        public int TotalOutcome { get; set; }

                        /// <summary>
                        /// 获取或设置收益（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("profit")]
                        [System.Text.Json.Serialization.JsonPropertyName("profit")]
                        public int Profit { get; set; }

                        /// <summary>
                        /// 获取或设置实际结算金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                        public int SettleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实际补贴金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_subsidy_amount")]
                        public int SubsidyAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单总价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public int TotalOrderAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品总价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_goods_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_goods_amount")]
                        public int TotalGoodsAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_amount")]
                        public int PostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("real_pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("real_pay_amount")]
                        public int ActualPayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置订单实付应结（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settled_pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settled_pay_amount")]
                        public int SettledPayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台券补贴金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_coupon")]
                        public int PlatformCouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置达人券补贴（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("author_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("author_coupon")]
                        public int AuthorCouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_promotion")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_promotion")]
                        public int PayPromotionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实际平台补贴金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_platform_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_platform_coupon")]
                        public int ActualPlatformCouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实际达人券补贴金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_author_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_author_coupon")]
                        public int ActualAuthorCouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实际支付补贴金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_pay_promotion")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_pay_promotion")]
                        public int ActualPayPromotionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置店铺优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_coupon")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_coupon")]
                        public int ShopCouponAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台服务费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_service_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_service_fee")]
                        public int PlatformServiceFee { get; set; }

                        /// <summary>
                        /// 获取或设置订单退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund")]
                        public int OrderRefund { get; set; }

                        /// <summary>
                        /// 获取或设置达人佣金（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission")]
                        public int AuthorCommission { get; set; }

                        /// <summary>
                        /// 获取或设置“好好学习”渠道费用（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("good_learn_channel_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("good_learn_channel_fee")]
                        public int GoodLearnChannelFee { get; set; }

                        /// <summary>
                        /// 获取或设置招商服务费（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("colonel_service_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("colonel_service_fee")]
                        public int ColonelServiceFee { get; set; }

                        /// <summary>
                        /// 获取或设置退佣失败垫付金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_refund_loss")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_refund_loss")]
                        public int ShopRefundLoss { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置返回编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string ReturnCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置返回信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("code_msg")]
                public string? ReturnMessage { get; set; }

                /// <summary>
                /// 获取或设置账单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Bill[] BillList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_cnt")]
                [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int PageSize { get; set; }
            }
        }
    }
}
