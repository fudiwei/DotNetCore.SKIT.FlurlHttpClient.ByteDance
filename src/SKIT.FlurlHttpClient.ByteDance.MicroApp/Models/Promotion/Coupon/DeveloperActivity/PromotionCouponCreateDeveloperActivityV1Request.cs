namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/create_developer_activity/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponCreateDeveloperActivityV1Request : DouyinMicroAppRequest
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
        /// 获取或设置商家活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_activity_id")]
        public string MerchantActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置活动名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_name")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        public string ActivityName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置计划库存数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_stock_number")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_stock_number")]
        public int CouponStockNumber { get; set; }
    }
}
