namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/brand 接口的请求。</para>
    /// </summary>
    public class ProductCreateBrandRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置品牌名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_name")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
        public string BrandName { get; set; } = string.Empty;
    }
}
