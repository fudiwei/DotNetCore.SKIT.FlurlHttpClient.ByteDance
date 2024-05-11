using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /product/{version}/products 接口的请求。</para>
    /// </summary>
    public class ProductDeleteProductsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<string> ProductIdList { get; set; } = new List<string>();
    }
}
