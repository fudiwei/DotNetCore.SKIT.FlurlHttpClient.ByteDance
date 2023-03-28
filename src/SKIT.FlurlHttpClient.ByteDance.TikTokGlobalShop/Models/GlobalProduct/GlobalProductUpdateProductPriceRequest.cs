using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /product/global_products/prices 接口的请求。</para>
    /// </summary>
    public class GlobalProductUpdateProductPriceRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class GlobalSKU
            {
                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string GlobalSKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置原价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_price")]
                [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                public decimal OriginalPrice { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置全球商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("global_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("global_product_id")]
        public string GlobalProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置全球 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.GlobalSKU> GlobalSKUList { get; set; } = new List<Types.GlobalSKU>();
    }
}
