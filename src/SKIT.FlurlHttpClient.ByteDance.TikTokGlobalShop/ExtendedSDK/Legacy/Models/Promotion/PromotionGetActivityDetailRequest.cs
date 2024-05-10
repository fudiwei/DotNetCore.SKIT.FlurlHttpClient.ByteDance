namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /promotion/activity/get 接口的请求。</para>
    /// </summary>
    public class PromotionGetActivityDetailRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置促销 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PromotionId { get; set; } = string.Empty;
    }
}
