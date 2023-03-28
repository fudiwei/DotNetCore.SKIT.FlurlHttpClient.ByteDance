using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/global_products/publish 接口的请求。</para>
    /// </summary>
    public class GlobalProductPublishProductRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Shop
            {
                public static class Types
                {
                    public class GlobalSKU
                    {
                        /// <summary>
                        /// 获取或设置全球 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string GlobalSKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置原价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                        public decimal? OriginalPrice { get; set; }

                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                        public string? WarehouseId { get; set; }

                        /// <summary>
                        /// 获取或设置可用库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_stock")]
                        public int AvailableStock { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置店铺所在地。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("region")]
                [System.Text.Json.Serialization.JsonPropertyName("region")]
                public string Region { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置全球 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("global_product_sku")]
                [System.Text.Json.Serialization.JsonPropertyName("global_product_sku")]
                public IList<Types.GlobalSKU> GlobalSKUList { get; set; } = new List<Types.GlobalSKU>();
            }
        }

        /// <summary>
        /// 获取或设置全球商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("global_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("global_product_id")]
        public string GlobalProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置店铺列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publishable_shops")]
        [System.Text.Json.Serialization.JsonPropertyName("publishable_shops")]
        public IList<Types.Shop> ShopList { get; set; } = new List<Types.Shop>();
    }
}
