namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/search 接口的响应。</para>
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
                                    public class Price
                                    {
                                        /// <summary>
                                        /// 获取或设置币种。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("currency")]
                                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                        public string Currency { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置售价。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sale_price")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal SalePrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置不含税价格。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("tax_exclusive_price")]
                                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                        [System.Text.Json.Serialization.JsonPropertyName("tax_exclusive_price")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal TaxExclusivePrice { get; set; }
                                    }

                                    public class Inventory
                                    {
                                        /// <summary>
                                        /// 获取或设置仓库 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                                        public string WarehouseId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置库存数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("quantity")]
                                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                        public int Quantity { get; set; }
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
                                [Newtonsoft.Json.JsonProperty("inventory")]
                                [System.Text.Json.Serialization.JsonPropertyName("inventory")]
                                public Types.Inventory[]? InventoryList { get; set; }

                                /// <summary>
                                /// 获取或设置价格信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public Types.Price Price { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }
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
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

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
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置同步失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_sync_fail_reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_sync_fail_reasons")]
                        public string? SyncFailReason { get; set; }

                        /// <summary>
                        /// 获取或设置销售地区编码列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_regions")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_regions")]
                        public string[]? SalesRegionCodeList { get; set; }
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
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
