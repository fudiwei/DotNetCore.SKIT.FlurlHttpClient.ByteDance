namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/coupon/create_coupon_meta/ 接口的响应。</para>
    /// </summary>
    public class PromotionCouponCreateCouponMetaV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置券模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
                public string CouponMetaId { get; set; } = default!;
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
