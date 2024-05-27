namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/query_activity_meta_data/ 接口的响应。</para>
    /// </summary>
    public class PromotionCouponQueryActivityMetaDataV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Activity
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                        public string AppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_icon")]
                        public string AppIconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                        public string ActivityId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
                        public string ActivityName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置使用须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consume_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("consume_desc")]
                        public string? ConsumeDescription { get; set; }

                        /// <summary>
                        /// 获取或设置使用时间说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consume_time_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("consume_time_desc")]
                        public string? ConsumeTimeDescription { get; set; }

                        /// <summary>
                        /// 获取或设置券模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                        public string CouponMetaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_meta_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_name")]
                        public string CouponName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_icon")]
                        public string CouponIconUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优惠类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_type")]
                        public int DiscountType { get; set; }

                        /// <summary>
                        /// 获取或设置优惠类型名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_type_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_type_name")]
                        public string DiscountTypeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置可领取开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_begin_time")]
                        public long ReceiveBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置可领取结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_end_time")]
                        public long ReceiveEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置剩余库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("remain_stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("remain_stock")]
                        public long RemainStock { get; set; }

                        /// <summary>
                        /// 获取或设置总库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_stock")]
                        public long TotalStock { get; set; }

                        /// <summary>
                        /// 获取或设置优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int DiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置是否支持分享裂变。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("support_share_fission")]
                        [System.Text.Json.Serialization.JsonPropertyName("support_share_fission")]
                        public bool IsSupportShareFission { get; set; }

                        /// <summary>
                        /// 获取或设置分享裂变说明。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_fission_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_fission_desc")]
                        public string? ShareFissionDescription { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_list")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_list")]
                public Types.Activity[] ActivityList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
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
