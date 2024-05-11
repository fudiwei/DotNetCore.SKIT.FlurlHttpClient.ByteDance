namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/inventory/search 接口的响应。</para>
    /// </summary>
    public class ProductGetInventoriesResponse : TikTokShopResponse<ProductGetInventoriesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductInventory
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                public static class Types
                                {
                                    public class Inventory
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
                                        [Newtonsoft.Json.JsonProperty("available_quantity")]
                                        [System.Text.Json.Serialization.JsonPropertyName("available_quantity")]
                                        public int AvailableQuantity { get; set; }

                                        /// <summary>
                                        /// 获取或设置已提交库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("committed_quantity")]
                                        [System.Text.Json.Serialization.JsonPropertyName("committed_quantity")]
                                        public int CommittedQuantity { get; set; }
                                    }

                                    public class InventoryDistribution
                                    {
                                        public static class Types
                                        {
                                            public class InShopInventory
                                            {
                                                /// <summary>
                                                /// 获取或设置库存数量。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("quantity")]
                                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                                public int Quantity { get; set; }
                                            }

                                            public class CampaignInventory : InShopInventory
                                            {
                                                /// <summary>
                                                /// 获取或设置活动名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("campaign_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("campaign_name")]
                                                public string CampaignName { get; set; } = default!;
                                            }

                                            public class CreatorInventory : InShopInventory
                                            {
                                                /// <summary>
                                                /// 获取或设置创建者名称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("creator_name")]
                                                [System.Text.Json.Serialization.JsonPropertyName("creator_name")]
                                                public string CreatorName { get; set; } = default!;
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置活动库存列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("campaign_inventory")]
                                        [System.Text.Json.Serialization.JsonPropertyName("campaign_inventory")]
                                        public Types.CampaignInventory[]? CampaignInventoryList { get; set; }

                                        /// <summary>
                                        /// 获取或设置创建者库存列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("creator_inventory")]
                                        [System.Text.Json.Serialization.JsonPropertyName("creator_inventory")]
                                        public Types.CreatorInventory[]? CreatorInventoryList { get; set; }

                                        /// <summary>
                                        /// 获取或设置在店库存列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("in_shop_inventory")]
                                        [System.Text.Json.Serialization.JsonPropertyName("in_shop_inventory")]
                                        public Types.InShopInventory? InShopInventory { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置库存列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("warehouse_inventory")]
                                [System.Text.Json.Serialization.JsonPropertyName("warehouse_inventory")]
                                public Types.Inventory[] InventoryList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置总可用库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_available_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_available_quantity")]
                                public int TotalAvailableQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置总已提交库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_committed_quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_committed_quantity")]
                                public int TotalCommittedQuantity { get; set; }

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置总可用库存分布信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_available_inventory_distribution")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_available_inventory_distribution")]
                                public Types.InventoryDistribution? TotalAvailableInventoryDistribution { get; set; }
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
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory")]
                public Types.ProductInventory[] ProductInventoryList { get; set; } = default!;
            }
        }
    }
}
