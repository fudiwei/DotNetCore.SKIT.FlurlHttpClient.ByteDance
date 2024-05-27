namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/get_coupon_receive_info 接口的响应。</para>
    /// </summary>
    public class PromotionCouponGetCouponReceiveInfoV1Response : DouyinMicroAppResponse
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
                        /// 获取或设置领券时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
                        public long ReceiveTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置商家券模板编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_meta_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_meta_no")]
                        public string MerchantMetaNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置券有效期开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                        public long ValidBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置券有效期结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long ValidEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置发放券的主播的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_open_id")]
                        public string? TalentOpenId { get; set; }

                        /// <summary>
                        /// 获取或设置发放券的主播的抖音号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_account")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_account")]
                        public string? TalentAccount { get; set; }

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
                        /// 获取或设置去使用券的小程序落地页页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consume_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("consume_path")]
                        public string? ConsumePagePath { get; set; }

                        /// <summary>
                        /// 获取或设置领取须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("receive_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("receive_desc")]
                        public string? ReceiveDescription { get; set; }

                        /// <summary>
                        /// 获取或设置使用须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consume_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("consume_desc")]
                        public string? ConsumeDescription { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置券列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_receive_list")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_receive_list")]
                public Types.Coupon[] CouponList { get; set; } = default!;
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
