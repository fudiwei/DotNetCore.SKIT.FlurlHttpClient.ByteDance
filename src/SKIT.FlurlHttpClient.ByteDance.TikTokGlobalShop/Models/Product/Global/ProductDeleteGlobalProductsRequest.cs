using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /product/{version}/global_products 接口的请求。</para>
    /// </summary>
    public class ProductDeleteGlobalProductsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("global_product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("global_product_ids")]
        public IList<string> ProductIdList { get; set; } = new List<string>();
    }
}
