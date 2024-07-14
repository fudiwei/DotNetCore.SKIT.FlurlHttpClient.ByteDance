namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/update_talent_coupon_status/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponUpdateTalentCouponStatusV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="DouyinMicroAppClient"/> 时的 <see cref="DouyinMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置账号类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public int AccountType { get; set; }

        /// <summary>
        /// 获取或设置主播的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? TalentOpenId { get; set; }

        /// <summary>
        /// 获取或设置主播抖音号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent_account")]
        [System.Text.Json.Serialization.JsonPropertyName("talent_account")]
        public string? TalentAccount { get; set; }

        /// <summary>
        /// 获取或设置券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_meta_id")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_meta_id")]
        public string CouponMetaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发券状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
