namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/update_coupon_meta_status 接口的请求。</para>
    /// </summary>
    public class PromotionCouponUpdateCouponMetaStatusV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
        public string CouponMetaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券模板状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta_status")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_status")]
        public int Status { get; set; }
    }
}
