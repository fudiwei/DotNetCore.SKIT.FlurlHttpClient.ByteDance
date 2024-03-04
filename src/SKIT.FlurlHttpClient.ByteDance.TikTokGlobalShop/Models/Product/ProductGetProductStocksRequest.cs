using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/stock/list 接口的请求。</para>
    /// </summary>
    public class ProductGetProductStocksRequest : TikTokShopRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? ApiVersion { get; set; } = "202305";

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
