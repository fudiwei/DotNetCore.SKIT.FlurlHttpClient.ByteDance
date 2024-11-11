namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/{version}/coupons/search 接口的响应。</para>
    /// </summary>
    public class PromotionSearchCouponsResponse : TikTokShopResponse<PromotionSearchCouponsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Coupon
                    {
                        public static class Types
                        {
                            public class ClaimDuration
                            {
                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long EndTimestamp { get; set; }
                            }

                            public class RedemptionDuration
                            {
                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置开始时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("start_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                public long? StartTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置结束时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("end_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                public long? EndTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置相对时间（单位：天）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("relative_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("relative_time")]
                                public int? RelativeTimeDays { get; set; }
                            }

                            public class UsageLimitation
                            {
                                /// <summary>
                                /// 获取或设置单个用户领取上限。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("single_buyer_claim_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("single_buyer_claim_limit")]
                                public int? SingleBuyerClaimLimit { get; set; }

                                /// <summary>
                                /// 获取或设置领取上限。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_claim_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_claim_limit")]
                                public int? TotalClaimLimit { get; set; }

                                /// <summary>
                                /// 获取或设置使用上限。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("redemption_limit")]
                                [System.Text.Json.Serialization.JsonPropertyName("redemption_limit")]
                                public int? TotalRedemptionLimit { get; set; }
                            }

                            public class Discount
                            {
                                public static class Types
                                {
                                    public class ReductionAmount
                                    {
                                        /// <summary>
                                        /// 获取或设置金额。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal Amount { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置币种。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("currency")]
                                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                        public string Currency { get; set; } = default!;
                                    }

                                    public class MaxDiscount
                                    {
                                        /// <summary>
                                        /// 获取或设置金额。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal Amount { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置币种。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("currency")]
                                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                        public string Currency { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置减免金额信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reduction_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("reduction_amount")]
                                public Types.ReductionAmount? ReductionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置折扣比例（单位：百分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("percentage")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("percentage")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? Percentage { get; set; }

                                /// <summary>
                                /// 获取或设置最高折扣信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("max_discount")]
                                [System.Text.Json.Serialization.JsonPropertyName("max_discount")]
                                public Types.MaxDiscount? MaxDiscount { get; set; }
                            }

                            public class Threshold
                            {
                                public static class Types
                                {
                                    public class MinSpend
                                    {
                                        /// <summary>
                                        /// 获取或设置金额。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal Amount { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置币种。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("currency")]
                                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                        public string Currency { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置最低消费信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("min_spend")]
                                [System.Text.Json.Serialization.JsonPropertyName("min_spend")]
                                public Types.MinSpend? MinSpend { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置优惠券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CouponId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠券名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠券状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置展示方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_type")]
                        public string DisplayType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置领取期限信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("claim_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("claim_duration")]
                        public Types.ClaimDuration ClaimDuration { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置使用期限信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("redemption_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("redemption_duration")]
                        public Types.RedemptionDuration RedemptionDuration { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promo_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("promo_code")]
                        public string? PromoCode { get; set; }

                        /// <summary>
                        /// 获取或设置目标买家细分类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("target_buyer_segment")]
                        [System.Text.Json.Serialization.JsonPropertyName("target_buyer_segment")]
                        public string? TargetBuyerSegment { get; set; }

                        /// <summary>
                        /// 获取或设置使用限制信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("usage_limits")]
                        [System.Text.Json.Serialization.JsonPropertyName("usage_limits")]
                        public Types.UsageLimitation? UsageLimitation { get; set; }

                        /// <summary>
                        /// 获取或设置优惠信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public Types.Discount Discount { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置门槛信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("threshold")]
                        [System.Text.Json.Serialization.JsonPropertyName("threshold")]
                        public Types.Threshold Threshold { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_scope")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_scope")]
                        public string? ProductScope { get; set; }

                        /// <summary>
                        /// 获取或设置创建来源。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creation_source")]
                        [System.Text.Json.Serialization.JsonPropertyName("creation_source")]
                        public string? CreationSource { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupons")]
                [System.Text.Json.Serialization.JsonPropertyName("coupons")]
                public Types.Coupon[] CouponList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

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
