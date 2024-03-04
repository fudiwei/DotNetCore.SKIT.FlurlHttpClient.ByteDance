namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/search 接口的响应。</para>
    /// </summary>
    public class ProductSearchProductsResponse : TikTokShopResponse<ProductSearchProductsResponse.Types.Data>
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
                                    public class PriceInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置币种。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("currency")]
                                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                        public string Currency { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置原价。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("original_price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal OriginalPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置含税价。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("price_include_vat")]
                                        [System.Text.Json.Serialization.JsonPropertyName("price_include_vat")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal PriceIncludeVAT { get; set; }
                                    }

                                    public class StockInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置仓库 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                        public string WarehouseId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置可用库存。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("available_stock")]
                                        [System.Text.Json.Serialization.JsonPropertyName("available_stock")]
                                        public int AvailableStock { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置价格信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public Types.PriceInfo PriceInfo { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置库存信息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("stock_infos")]
                                [System.Text.Json.Serialization.JsonPropertyName("stock_infos")]
                                public Types.StockInfo[] StockInfoList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string ProductName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int ProductStatus { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置销售地区列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_regions")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_regions")]
                        public string[]? SalesRegionList { get; set; }

                        /// <summary>
                        /// 获取或设置全球同步失败原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("global_sync_failed_reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("global_sync_failed_reasons")]
                        public string[]? GlobalSyncFailedReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
