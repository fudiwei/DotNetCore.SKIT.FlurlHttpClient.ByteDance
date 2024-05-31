using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/order/create_order 接口的请求。</para>
    /// </summary>
    public class AppsTradeOrderCreateOrderV2Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class Goods
            {
                public static class Types
                {
                    public class OrderValidTime
                    {
                        /// <summary>
                        /// 获取或设置有效期开始时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_start_time")]
                        public long? StartTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置有效期结束时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long? EndTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置有效时长（单位：毫秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_duration")]
                        public int? Duration { get; set; }
                    }

                    public class BookingInfo
                    {
                        /// <summary>
                        /// 获取或设置预约类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("book_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("book_type")]
                        public int BookType { get; set; }

                        /// <summary>
                        /// 获取或设置取消政策。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_policy")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_policy")]
                        public int? CancelPolicy { get; set; }

                        /// <summary>
                        /// 获取或设置提前取消的小时限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cancel_advance_hour")]
                        [System.Text.Json.Serialization.JsonPropertyName("cancel_advance_hour")]
                        public int? CancelAdvanceHours { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID 类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_id_type")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_id_type")]
                public int GoodsIdType { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_id")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                public string GoodsId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_title")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_title")]
                public string? GoodsTitle { get; set; }

                /// <summary>
                /// 获取或设置商品图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_image")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_image")]
                public string? GoodsImageUrl { get; set; }

                /// <summary>
                /// 获取或设置标签列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("labels")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedStringListWithPipeSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("labels")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedStringListWithPipeSplitConverter))]
                public IList<string>? LabelList { get; set; }

                /// <summary>
                /// 获取或设置使用规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("date_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("date_rule")]
                public string? DateRuleText { get; set; }

                /// <summary>
                /// 获取或设置价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int? Price { get; set; }

                /// <summary>
                /// 获取或设置折扣金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                public int? DiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                public int Quantity { get; set; }

                /// <summary>
                /// 获取或设置收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置商品详情页的 Schema。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_page")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_page")]
                public MicroAppSchema? GoodsPageSchema { get; set; }

                /// <summary>
                /// 获取或设置券的有效期。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_valid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_valid_time")]
                public Types.OrderValidTime? OrderValidTime { get; set; }

                /// <summary>
                /// 获取或设置预约信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_book_info")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_book_info")]
                public Types.BookingInfo? BookingInfo { get; set; }
            }

            public class PriceCalculationDetail
            {
                public static class Types
                {
                    public class GoodsDiscountDetail
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                        public string GoodsId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置商品总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public int TotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品优惠总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_discount_amount")]
                        public int TotalDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置营销明细列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("marketing_detail_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("marketing_detail_info")]
                        public IList<MarketingDetail>? MarketingDetailList { get; set; }
                    }

                    public class ItemDiscountDetail
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_id")]
                        public string GoodsId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public int TotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品优惠总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_discount_amount")]
                        public int TotalDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置营销明细列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("marketing_detail_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("marketing_detail_info")]
                        public IList<MarketingDetail>? MarketingDetailList { get; set; }
                    }

                    public class OrderDiscountDetail
                    {
                        /// <summary>
                        /// 获取或设置订单优惠总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_total_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_total_discount_amount")]
                        public int OrderTotalDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商品优惠总金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_total_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_total_discount_amount")]
                        public int GoodsTotalDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置营销明细列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("marketing_detail_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("marketing_detail_info")]
                        public IList<MarketingDetail>? MarketingDetailList { get; set; }
                    }

                    public class MarketingDetail
                    {
                        /// <summary>
                        /// 获取或设置营销 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置营销类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置营销子类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subtype")]
                        [System.Text.Json.Serialization.JsonPropertyName("subtype")]
                        public string? SubType { get; set; }

                        /// <summary>
                        /// 获取或设置优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int DiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置优惠范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_range")]
                        public int DiscountRange { get; set; }

                        /// <summary>
                        /// 获取或设置营销名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置营销备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("note")]
                        [System.Text.Json.Serialization.JsonPropertyName("note")]
                        public string? Notes { get; set; }

                        /// <summary>
                        /// 获取或设置值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public long? Value { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置算价类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("calculation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("calculation_type")]
                public int CalculationType { get; set; }

                /// <summary>
                /// 获取或设置商品算价结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_discount_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_discount_detail")]
                public IList<Types.GoodsDiscountDetail>? GoodsDiscountDetailList { get; set; }

                /// <summary>
                /// 获取或设置单商品算价结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_discount_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("item_discount_detail")]
                public IList<Types.ItemDiscountDetail>? ItemDiscountDetailList { get; set; }

                /// <summary>
                /// 获取或设置订单算价结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_discount_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_discount_detail")]
                public Types.OrderDiscountDetail? OrderDiscountDetail { get; set; }
            }

            public class MicroAppSchema
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面参数字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("params")]
                [System.Text.Json.Serialization.JsonPropertyName("params")]
                public string? ParamsString { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置开发者订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置折扣金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
        public int? DiscountAmount { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_list")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_list")]
        public IList<Types.Goods> GoodsList { get; set; } = new List<Types.Goods>();

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra")]
        [System.Text.Json.Serialization.JsonPropertyName("extra")]
        public string? Notes { get; set; }

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cp_extra")]
        [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置用户姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
        public string? ContactName { get; set; }

        /// <summary>
        /// 获取或设置用户手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_num")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_num")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置支付超时时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_expire_seconds")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_expire_seconds")]
        public int? PayExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置订单详情页的 Schema。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_entry_schema")]
        [System.Text.Json.Serialization.JsonPropertyName("order_entry_schema")]
        public Types.MicroAppSchema? OrderEntrySchema { get; set; }

        /// <summary>
        /// 获取或设置营销算价结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price_calculation_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("price_calculation_detail")]
        public Types.PriceCalculationDetail? PriceCalculationDetail { get; set; }
    }
}
