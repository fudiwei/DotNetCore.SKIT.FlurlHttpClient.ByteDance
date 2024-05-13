namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/global_products/{global_product_id} 接口的响应。</para>
    /// </summary>
    public class ProductGetGlobalProductDetailResponse : TikTokShopResponse<ProductGetGlobalProductDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Image : ProductGetProductDetailResponse.Types.Data.Types.Image
                    {
                    }

                    public class Video : ProductGetProductDetailResponse.Types.Data.Types.Video
                    {
                    }

                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CategoryId { get; set; } = default!;
                    }

                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string BrandId { get; set; } = default!;
                    }

                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string RegionCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置产品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ProductId { get; set; } = default!;
                    }

                    public class SKU
                    {
                        public static class Types
                        {
                            public class SalesAttribute : ProductGetProductDetailResponse.Types.Data.Types.SKU.Types.SalesAttribute
                            {
                            }

                            public class Price
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置价格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal Amount { get; set; }

                                /// <summary>
                                /// 获取或设置库存单价。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unit_price")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberReadOnlyConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal UnitPrice { get; set; }
                            }

                            public class Inventory
                            {
                                /// <summary>
                                /// 获取或设置仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("global_warehouse_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("global_warehouse_id")]
                                public string WarehouseId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置库存数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }
                            }

                            public class IdentifierCode : ProductGetProductDetailResponse.Types.Data.Types.SKU.Types.IdentifierCode
                            {
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
                        /// 获取或设置销售属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                        public Types.SalesAttribute[]? SalesAttributeList { get; set; }

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

                        /// <summary>
                        /// 获取或设置产品标识码信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("identifier_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("identifier_code")]
                        public Types.IdentifierCode? IdentifierCode { get; set; }

                        /// <summary>
                        /// 获取或设置全球数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("global_quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("global_quantity")]
                        public int? GlobalQuantity { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 单位数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_unit_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_unit_count")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal? UnitCount { get; set; }
                    }

                    public class PackageDimension : ProductGetProductDetailResponse.Types.Data.Types.PackageDimension
                    {
                    }

                    public class PackageWeight : ProductGetProductDetailResponse.Types.Data.Types.PackageWeight
                    {
                    }

                    public class Certification : ProductGetProductDetailResponse.Types.Data.Types.Certification
                    {
                    }

                    public class ProductAttribute : ProductGetProductDetailResponse.Types.Data.Types.ProductAttribute
                    {
                    }

                    public class SizeChart : ProductGetProductDetailResponse.Types.Data.Types.SizeChart
                    {
                    }

                    public class Manufacturer : ProductGetProductDetailResponse.Types.Data.Types.Manufacturer
                    {
                        /// <summary>
                        /// 获取或设置制造商名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置制造商地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }

                        /// <summary>
                        /// 获取或设置联系电话。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("phone_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
                        public string? PhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置联系邮箱。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        public string? Email { get; set; }
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
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

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
                /// 获取或设置分类信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category")]
                [System.Text.Json.Serialization.JsonPropertyName("category")]
                public Types.Category Category { get; set; } = default!;

                /// <summary>
                /// 获取或设置品牌信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand")]
                [System.Text.Json.Serialization.JsonPropertyName("brand")]
                public Types.Brand? Brand { get; set; }

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_images")]
                [System.Text.Json.Serialization.JsonPropertyName("main_images")]
                public Types.Image[]? MainImageList { get; set; }

                /// <summary>
                /// 获取或设置视频信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.Video? Video { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[] SKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置包装尺寸信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_dimensions")]
                [System.Text.Json.Serialization.JsonPropertyName("package_dimensions")]
                public Types.PackageDimension? PackageDimension { get; set; }

                /// <summary>
                /// 获取或设置包装重量信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("package_weight")]
                public Types.PackageWeight? PackageWeight { get; set; }

                /// <summary>
                /// 获取或设置尺码表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size_chart")]
                [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
                public Types.SizeChart? SizeChart { get; set; }

                /// <summary>
                /// 获取或设置商品认证列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certifications")]
                [System.Text.Json.Serialization.JsonPropertyName("certifications")]
                public Types.Certification[]? CertificationList { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("product_attributes")]
                public Types.ProductAttribute[]? ProductAttributeList { get; set; }

                /// <summary>
                /// 获取或设置制造商信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manufacturer")]
                [System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
                public Types.Manufacturer? Manufacturer { get; set; }

                /// <summary>
                /// 获取或设置全球卖家 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("global_seller_id")]
                [System.Text.Json.Serialization.JsonPropertyName("global_seller_id")]
                public string? GlobalSellerId { get; set; }
            }
        }
    }
}
