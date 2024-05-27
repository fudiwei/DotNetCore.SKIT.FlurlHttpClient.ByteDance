namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/send_coupon_to_designated_user 接口的响应。</para>
    /// </summary>
    public class PromotionCouponSendCouponToDesignatedUserV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Coupon
                    {
                        /// <summary>
                        /// 获取或设置券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                        public string CouponId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
                        public string CouponName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("coupon_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("coupon_status")]
                        public int CouponStatus { get; set; }

                        /// <summary>
                        /// 获取或设置优惠类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_type")]
                        public int DiscountType { get; set; }

                        /// <summary>
                        /// 获取或设置优惠金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_amount")]
                        public int? DiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置满减门槛金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min_pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("min_pay_amount")]
                        public int? MinPayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置商家券模板编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_meta_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_meta_no")]
                        public string MerchantMetaNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置使用有效期开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public long ValidBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置使用有效期结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long ValidEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置领取时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
                        public long ReceiveTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                public Types.Coupon Coupon { get; set; } = default!;
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
