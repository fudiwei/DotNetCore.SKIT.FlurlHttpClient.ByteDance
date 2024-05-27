namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/coupon/modify_coupon_meta/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponModifyCouponMetaV2Request : DouyinMicroAppRequest
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
                public string CouponMetaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置券名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_name")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_name")]
                public string? CouponName { get; set; }

                /// <summary>
                /// 获取或设置使用须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_desc")]
                public string? ConsumeDescription { get; set; } 

                /// <summary>
                /// 获取或设置使用链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consume_path")]
                [System.Text.Json.Serialization.JsonPropertyName("consume_path")]
                public string? ConsumePagePath { get; set; }

                /// <summary>
                /// 获取或设置可领取开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_begin_time")]
                public long? ReceiveBeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置可领取结束时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_end_time")]
                public long? ReceiveEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置领取须知。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_desc")]
                public string? ReceiveDescription { get; set; }

                /// <summary>
                /// 获取或设置有效期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("valid_type")]
                [System.Text.Json.Serialization.JsonPropertyName("valid_type")]
                public int? ValidType { get; set; }

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
            }
        }

        /// <summary>
        /// 获取或设置券模板信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta")]
        public Types.CouponMeta CouponMeta { get; set; } = new Types.CouponMeta();
    }
}
