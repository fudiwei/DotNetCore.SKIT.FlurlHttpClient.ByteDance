namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /promotion/{version}/coupons/{coupon_id} 接口的响应。</para>
    /// </summary>
    public class PromotionGetCouponDetailResponse : TikTokShopResponse<PromotionGetCouponDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Coupon : PromotionSearchCouponsResponse.Types.Data.Types.Coupon
                    {
                        public static new class Types
                        {
                            public class UsageStatistics
                            {
                                /// <summary>
                                /// 获取或设置已领取数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("claimed_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("claimed_count")]
                                public int ClaimedCount { get; set; }

                                /// <summary>
                                /// 获取或设置已使用数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("redeemed_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("redeemed_count")]
                                public int RedeemedCount { get; set; }
                            }

                            public class LiveTask
                            {
                                /// <summary>
                                /// 获取或设置类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置最低观看时长（单位：秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("min_watch_time")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("min_watch_time")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public int? MinWatchTime { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置展示渠道列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("display_channels")]
                        [System.Text.Json.Serialization.JsonPropertyName("display_channels")]
                        public string[] DisplayChannelList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置使用统计信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("usage_stats")]
                        [System.Text.Json.Serialization.JsonPropertyName("usage_stats")]
                        public Types.UsageStatistics UsageStatistics { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置适用商品 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
                        public string[]? ProductIdList { get; set; }

                        /// <summary>
                        /// 获取或设置卖家自定义条款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_tnc")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_tnc")]
                        public string? SellerTNC { get; set; }

                        /// <summary>
                        /// 获取或设置直播任务列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_tasks")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_tasks")]
                        public Types.LiveTask[]? LiveTaskList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置优惠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon")]
                public Types.Coupon Coupon { get; set; } = default!;
            }
        }
    }
}
