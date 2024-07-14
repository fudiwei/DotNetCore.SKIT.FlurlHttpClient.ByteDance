namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/get_coupon_receive_info/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponGetCouponReceiveInfoV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
        public string? CouponId { get; set; }

        /// <summary>
        /// 获取或设置券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_status")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_status")]
        public int? CouponStatus { get; set; }
    }
}
