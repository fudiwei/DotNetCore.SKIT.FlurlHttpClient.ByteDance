namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/coupon/query_coupon_meta/ 接口的响应。</para>
    /// </summary>
    public class PromotionCouponQueryCouponMetaV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class CouponMeta
            {
                /// <summary>
                /// 获取或设置券模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                public string CouponMetaId { get; set; } = default!;

                /// <summary>
                /// 获取或设置券名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_name")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
                public string CouponName { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_desc")]
                public string ConsumeDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置使用链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_path")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_path")]
                public string ConsumePagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置商家券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_meta_no")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_meta_no")]
                public string MerchantMetaNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置券模板状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置优惠类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount_type")]
                [System.Text.Json.Serialization.JsonPropertyName("discount_type")]
                public int DiscountType { get; set; }

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
                /// 获取或设置领取须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_desc")]
                public string? ReceiveDescription { get; set; }

                /// <summary>
                /// 获取或设置最大库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_number")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_number")]
                public long StockNumber { get; set; }

                /// <summary>
                /// 获取或设置有效期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_type")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_type")]
                public int ValidType { get; set; }

                /// <summary>
                /// 获取或设置有效期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_begin_time")]
                public long? ValidBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效期结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                public long? ValidEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置有效时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_duration")]
                public int? ValidDuration { get; set; }

                /// <summary>
                /// 获取或设置回调地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("callback_url")]
                [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
                public string? CallbackUrl { get; set; }

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
                /// 获取或设置关联内容类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("related_type")]
                [System.Text.Json.Serialization.JsonPropertyName("related_type")]
                public int? RelatedType { get; set; }

                /// <summary>
                /// 获取或设置关联内容 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("origin_id")]
                [System.Text.Json.Serialization.JsonPropertyName("origin_id")]
                public string? RelatedOriginId { get; set; }

                /// <summary>
                /// 获取或设置密钥类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secret_source")]
                [System.Text.Json.Serialization.JsonPropertyName("secret_source")]
                public int SecretSource { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置券模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta")]
        public Types.CouponMeta CouponMeta { get; set; } = default!;
    }
}
