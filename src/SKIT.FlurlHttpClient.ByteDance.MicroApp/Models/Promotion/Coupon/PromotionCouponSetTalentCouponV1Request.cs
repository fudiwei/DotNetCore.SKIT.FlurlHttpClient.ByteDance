namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/promotion/v1/coupon/set_talent_coupon/ 接口的请求。</para>
    /// </summary>
    public class PromotionCouponSetTalentCouponV1Request : DouyinMicroAppRequest
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
        /// 获取或设置库存发放上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_limit")]
        public long StockLimit { get; set; }

        /// <summary>
        /// 获取或设置奖励券的库存上限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("award_stock_limit")]
        [System.Text.Json.Serialization.JsonPropertyName("award_stock_limit")]
        public long AwardStockLimit { get; set; }
    }
}
