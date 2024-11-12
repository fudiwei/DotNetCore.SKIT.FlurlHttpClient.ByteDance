namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /fbt/{version}/merchants/onboarded_regions 接口的请求。</para>
    /// </summary>
    public class FBTGetMerchantOnboardedRegionsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202409</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202409;
    }
}
