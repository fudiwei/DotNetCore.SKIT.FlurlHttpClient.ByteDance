using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [PUT] /products/stocks 接口的请求。</para>
    /// </summary>
    public class ProductUpdateProductStockRequest : TikTokShopLegacyRequest
    {
        public static class Types
        {
            public class SKU
            {
                public static class Types
                {
                    public class StockInfo : ProductCreateProductRequest.Types.SKU.Types.StockInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string SKUId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置库存信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_infos")]
                public IList<Types.StockInfo> StockInfoList { get; set; } = new List<Types.StockInfo>();
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
    }
}
