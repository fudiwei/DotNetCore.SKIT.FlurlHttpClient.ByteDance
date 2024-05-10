namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/stock/list 接口的响应。</para>
    /// </summary>
    public class ProductGetProductStocksResponse : TikTokShopLegacyResponse<ProductGetProductStocksResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                public static class Types
                                {
                                    public class WarehouseStockInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置仓库 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                                        public string WarehouseId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置可用库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("available_stock")]
                                        [System.Text.Json.Serialization.JsonPropertyName("available_stock")]
                                        public int AvailableStock { get; set; }

                                        /// <summary>
                                        /// 获取或设置已订购库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("committed_stock")]
                                        [System.Text.Json.Serialization.JsonPropertyName("committed_stock")]
                                        public int CommittedStock { get; set; }
                                    }

                                    public class TotalAvailableStockDistribution
                                    {
                                        public static class Types
                                        {
                                            public class CampaignStockInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置活动名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
                                                public string CampaignName { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置可用库存。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("available_stock")]
                                                [System.Text.Json.Serialization.JsonPropertyName("available_stock")]
                                                public int AvailableStock { get; set; }
                                            }

                                            public class CreatorStockInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置创作者名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("creator_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("creator_name")]
                                                public string CreatorName { get; set; } = default!;

                                                /// <summary>
                                                /// 获取或设置可用库存。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("available_stock")]
                                                [System.Text.Json.Serialization.JsonPropertyName("available_stock")]
                                                public int AvailableStock { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置活动库存列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("campaign_stock")]
                                        [System.Text.Json.Serialization.JsonPropertyName("campaign_stock")]
                                        public Types.CampaignStockInfo[]? CampaignStockList { get; set; }

                                        /// <summary>
                                        /// 获取或设置创作者库存列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("creator_stock")]
                                        [System.Text.Json.Serialization.JsonPropertyName("creator_stock")]
                                        public Types.CreatorStockInfo[]? CreatorStockList { get; set; }

                                        /// <summary>
                                        /// 获取或设置店内库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("in_shop_stock")]
                                        [System.Text.Json.Serialization.JsonPropertyName("in_shop_stock")]
                                        public int? InShopStock { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置总可用库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_available_stock")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_available_stock")]
                                public int TotalAvailableStock { get; set; }

                                /// <summary>
                                /// 获取或设置总已订购库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_committed_stock")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_committed_stock")]
                                public int TotalCommittedStock { get; set; }

                                /// <summary>
                                /// 获取或设置各仓库库存列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("warehouse_stock_infos")]
                                [System.Text.Json.Serialization.JsonPropertyName("warehouse_stock_infos")]
                                public Types.WarehouseStockInfo[] WarehouseStockList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置总可用库存分布信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_available_stock_distribution")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_available_stock_distribution")]
                                public Types.TotalAvailableStockDistribution TotalAvailableStockDistribution { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKU { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_stocks")]
                [System.Text.Json.Serialization.JsonPropertyName("product_stocks")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }
    }
}
