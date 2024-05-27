namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v2/coupon/query_coupon_meta/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponQueryCouponMetaV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
        public string CouponMetaId { get; set; } = string.Empty;
    }
}
