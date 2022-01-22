using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /buyin/instituteOrderAds 接口的响应。</para>
    /// </summary>
    public class BuyinInstituteOrderAdsResponse : TikTokShopResponse<BuyinInstituteOrderAdsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        public static class Types
                        {
                            public class Order
                            {
                                public static class Types
                                {
                                    public class Institution
                                    {
                                        /// <summary>
                                        /// 获取或设置机构 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("pid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("pid")]
                                        public string InstitutionId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置外部参数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("external_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("external_info")]
                                        public string? ExternalInformation { get; set; }

                                        /// <summary>
                                        /// 获取或设置分销类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("media_type_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("media_type_name")]
                                        public string DistributionType { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置订单 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                                public string OrderId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_img")]
                                public string ProductImageUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置商品价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int ProductPrice { get; set; }

                                /// <summary>
                                /// 获取或设置达人昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_account")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_account")]
                                public string AuthorName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置达人 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("author_openid")]
                                [System.Text.Json.Serialization.JsonPropertyName("author_openid")]
                                public string AuthorOpenId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 App 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("app")]
                                [System.Text.Json.Serialization.JsonPropertyName("app")]
                                public string AppName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置店铺 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                                public int ShopId { get; set; }

                                /// <summary>
                                /// 获取或设置店铺名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                                public string ShopName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置选品 App 的 ClientKey。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pick_source_client_key")]
                                [System.Text.Json.Serialization.JsonPropertyName("pick_source_client_key")]
                                public string? PickSourceClientKey { get; set; }

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("item_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("item_num")]
                                public int ItemCount { get; set; }

                                /// <summary>
                                /// 获取或设置订单支付金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_pay_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_pay_amount")]
                                public int TotalPayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置佣金率。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("commission_rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("commission_rate")]
                                public int CommissionRate { get; set; }

                                /// <summary>
                                /// 获取或设置达人预估佣金收入（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("estimated_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("estimated_commission")]
                                public int EstimatedCommission { get; set; }

                                /// <summary>
                                /// 获取或设置达人实际佣金收入（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("real_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("real_commission")]
                                public int ActualCommission { get; set; }

                                /// <summary>
                                /// 获取或设置订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("flow_point")]
                                [System.Text.Json.Serialization.JsonPropertyName("flow_point")]
                                public string OrderStatus { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置下单用户的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("buyer_openid")]
                                [System.Text.Json.Serialization.JsonPropertyName("buyer_openid")]
                                public string BuyerOpenId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置支付时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_success_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_success_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? PayTime { get; set; }

                                /// <summary>
                                /// 获取或设置预估参与结算金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_goods_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_goods_amount")]
                                public int EstimatedGoodsAmount { get; set; }

                                /// <summary>
                                /// 获取或设置实际参与结算金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settled_goods_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("settled_goods_amount")]
                                public int SettledGoodsAmount { get; set; }

                                /// <summary>
                                /// 获取或设置预估平台服务费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("estimated_tech_service_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("estimated_tech_service_fee")]
                                public int EstimatedServiceFee { get; set; }

                                /// <summary>
                                /// 获取或设置实际平台服务费（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settled_tech_service_fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("settled_tech_service_fee")]
                                public int SettledServiceFee { get; set; }

                                /// <summary>
                                /// 获取或设置预估总佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("estimated_total_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("estimated_total_commission")]
                                public int EstimatedTotalCommission { get; set; }

                                /// <summary>
                                /// 获取或设置渠道分成比例。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ads_split_rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("ads_split_rate")]
                                public int AdsSplitRate { get; set; }

                                /// <summary>
                                /// 获取或设置预估渠道佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ads_estimated_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("ads_estimated_commission")]
                                public int EstimatedAdsCommission { get; set; }

                                /// <summary>
                                /// 获取或设置实际渠道佣金（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ads_real_commission")]
                                [System.Text.Json.Serialization.JsonPropertyName("ads_real_commission")]
                                public int ActualAdsCommission { get; set; }

                                /// <summary>
                                /// 获取或设置结算时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settle_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? SettleTime { get; set; }

                                /// <summary>
                                /// 获取或设置退款时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                                public DateTimeOffset? RefundTime { get; set; }

                                /// <summary>
                                /// 获取或设置分销机构信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pid_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("pid_info")]
                                public Types.Institution Institution { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置更新时间。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                                public DateTimeOffset UpdateTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置订单列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("orders")]
                        [System.Text.Json.Serialization.JsonPropertyName("orders")]
                        public Types.Order[] OrderList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置下一页翻页索引。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cursor")]
                        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                        public string? NextCursor { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置查询结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Result Result { get; set; } = default!;
            }
        }
    }
}
