using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/inventory/search 接口的请求。</para>
    /// </summary>
    public class ProductGetInventoriesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("product_ids")]
        public IList<string>? ProductIdList { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_ids")]
        public IList<string>? SKUIdList { get; set; }
    }
}
