namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/global_products 接口的请求。</para>
    /// </summary>
    public class GlobalProductGetProductDetailRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置全球商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GlobalProductId { get; set; } = string.Empty;
    }
}
