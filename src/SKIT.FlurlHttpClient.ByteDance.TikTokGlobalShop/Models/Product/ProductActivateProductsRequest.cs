namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/activate 接口的请求。</para>
    /// </summary>
    public class ProductActivateProductsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public List<string>? ProductIdList { get; set; }

        /// <summary>
        /// 获取或设置上架平台列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("listing_platforms")]
        [System.Text.Json.Serialization.JsonPropertyName("listing_platforms")]
        public List<string>? ListingPlatformList { get; set; }
    }
}
