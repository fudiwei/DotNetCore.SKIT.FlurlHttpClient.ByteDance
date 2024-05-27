namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/delete_coupon_meta 接口的请求。</para>
    /// </summary>
    public class PromotionCouponDeleteCouponMetaV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置券模板 ID。与字段 <see cref="MerchantMetaNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
        public string? CouponMetaId { get; set; }

        /// <summary>
        /// 获取或设置商家券模板编号。与字段 <see cref="CouponMetaId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_meta_no")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_meta_no")]
        public string? MerchantMetaNumber { get; set; }
    }
}
