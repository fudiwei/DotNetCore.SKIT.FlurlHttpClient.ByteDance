namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/attributes 接口的请求。</para>
    /// </summary>
    public class ProductGetAttributeListRequest : TikTokShopLegacyRequest
    {
        /// <summary>
        /// 获取或设置分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CategoryId { get; set; } = string.Empty;
    }
}
