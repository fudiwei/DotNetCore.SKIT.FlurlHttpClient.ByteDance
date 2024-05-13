namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/products/{product_id} 接口的响应。</para>
    /// </summary>
    public class ProductGetProductDetailResponse : TikTokShopResponse<ProductGetProductDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 URI。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("uri")]
                        public string Uri { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("urls")]
                        public string[] UrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置缩略图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_urls")]
                        public string[] ThumbUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置图片高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }
                    }

                    public class Video
                    {
                        /// <summary>
                        /// 获取或设置文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string FileId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文件格式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("format")]
                        [System.Text.Json.Serialization.JsonPropertyName("format")]
                        public string Format { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置文件 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置封面图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover_url")]
                        public string CoverUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置视频高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置文件大小（单位：字节）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("size")]
                        [System.Text.Json.Serialization.JsonPropertyName("size")]
                        public int Size { get; set; }
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

                        /// <summary>
                        /// 获取或设置上级分类 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("parent_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ParentCategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是子分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_leaf")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                        public bool IsLeaf { get; set; }
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

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }

                    public class SKU
                    {
                        public static class Types
                        {
                            public class SalesAttribute
                            {
                                public static class Types
                                {
                                    public class Image : ProductGetProductDetailResponse.Types.Data.Types.Image
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置属性 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string AttributeId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string? Name { get; set; }

                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                public string? ValueId { get; set; }

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                                public string? ValueName { get; set; }

                                /// <summary>
                                /// 获取或设置图片信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_img")]
                                public Types.Image? Image { get; set; }
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

                            public class IdentifierCode
                            {
                                /// <summary>
                                /// 获取或设置标识码类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置标识码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public string Code { get; set; } = default!;
                            }

                            public class CombinedSKU
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public string ProductId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_count")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_count")]
                                public int SKUCount { get; set; }
                            }

                            public class GlobalListingPolicy
                            {
                                public static class Types
                                {
                                    public class ReplicateSource
                                    {
                                        /// <summary>
                                        /// 获取或设置店铺 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("shop_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                                        public string ShopId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                        public string ProductId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置 SKU ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sku_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                        public string SKUId { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置是否价格同步。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price_sync")]
                                [System.Text.Json.Serialization.JsonPropertyName("price_sync")]
                                public bool IsPriceSync { get; set; }

                                /// <summary>
                                /// 获取或设置库存类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("inventory_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("inventory_type")]
                                public string InventoryType { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置副本源信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("replicate_source")]
                                [System.Text.Json.Serialization.JsonPropertyName("replicate_source")]
                                public Types.ReplicateSource? ReplicateSource { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置外部 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_sku_id")]
                        public string? ExternalSKUId { get; set; }

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
                        /// 获取或设置组合 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("combined_skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("combined_skus")]
                        public Types.CombinedSKU[]? CombinedSKUList { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 单位数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_unit_count")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_unit_count")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal? UnitCount { get; set; }

                        /// <summary>
                        /// 获取或设置全球商品上架策略信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("global_listing_policy")]
                        [System.Text.Json.Serialization.JsonPropertyName("global_listing_policy")]
                        public Types.GlobalListingPolicy? GlobalListingPolicy { get; set; }
                    }

                    public class PackageDimension
                    {
                        /// <summary>
                        /// 获取或设置长度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("length")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("length")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Length { get; set; }

                        /// <summary>
                        /// 获取或设置宽度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Width { get; set; }

                        /// <summary>
                        /// 获取或设置高度。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Height { get; set; }

                        /// <summary>
                        /// 获取或设置尺寸单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string Unit { get; set; } = default!;
                    }

                    public class PackageWeight
                    {
                        /// <summary>
                        /// 获取或设置重量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal Value { get; set; }

                        /// <summary>
                        /// 获取或设置重量单位。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit")]
                        public string Unit { get; set; } = default!;
                    }

                    public class Certification
                    {
                        public static class Types
                        {
                            public class Image : ProductGetProductDetailResponse.Types.Data.Types.Image
                            {
                            }

                            public class File
                            {
                                /// <summary>
                                /// 获取或设置文件 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string FileId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置文件名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置文件格式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("format")]
                                [System.Text.Json.Serialization.JsonPropertyName("format")]
                                public string Format { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置文件 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("urls")]
                                [System.Text.Json.Serialization.JsonPropertyName("urls")]
                                public string[] UrlList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品认证 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string CertificationId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品认证名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("images")]
                        [System.Text.Json.Serialization.JsonPropertyName("images")]
                        public Types.Image[]? ImageList { get; set; }

                        /// <summary>
                        /// 获取或设置文件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("files")]
                        [System.Text.Json.Serialization.JsonPropertyName("files")]
                        public Types.File[]? FileList { get; set; }
                    }

                    public class ProductAttribute
                    {
                        public static class Types
                        {
                            public class ProductAttributeValue
                            {
                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string AttributeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public Types.ProductAttributeValue[] ValueList { get; set; } = default!;
                    }

                    public class SizeChart
                    {
                        public static class Types
                        {
                            public class Image : ProductGetProductDetailResponse.Types.Data.Types.Image
                            {
                            }

                            public class Template
                            {
                                /// <summary>
                                /// 获取或设置模板 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public string TemplateId { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image")]
                        [System.Text.Json.Serialization.JsonPropertyName("image")]
                        public Types.Image? Image { get; set; }

                        /// <summary>
                        /// 获取或设置模板信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template")]
                        [System.Text.Json.Serialization.JsonPropertyName("template")]
                        public Types.Template? Template { get; set; }
                    }

                    public class DeliveryOption
                    {
                        /// <summary>
                        /// 获取或设置配送方式 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string DeliveryOptionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否可用。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_available")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_available")]
                        public bool IsAvailable { get; set; }
                    }

                    public class Manufacturer
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

                    public class AuditFailedReason
                    {
                        /// <summary>
                        /// 获取或设置位置。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("position")]
                        [System.Text.Json.Serialization.JsonPropertyName("position")]
                        public string Position { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置拒绝原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("reasons")]
                        public string[] ReasonList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置修改建议列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("suggestions")]
                        [System.Text.Json.Serialization.JsonPropertyName("suggestions")]
                        public string[] SuggestionList { get; set; } = default!;
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
                /// 获取或设置外部商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("external_product_id")]
                public string? ExternalProductId { get; set; }

                /// <summary>
                /// 获取或设置商品类型列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_types")]
                [System.Text.Json.Serialization.JsonPropertyName("product_types")]
                public string? ProductTypeList { get; set; }

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
                /// 获取或设置分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_chains")]
                [System.Text.Json.Serialization.JsonPropertyName("category_chains")]
                public Types.Category[] CategoryList { get; set; } = default!;

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
                /// 获取或设置是否允许货到付款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_cod_allowed")]
                [System.Text.Json.Serialization.JsonPropertyName("is_cod_allowed")]
                public bool IsCashOnDeliveryAllowed { get; set; }

                /// <summary>
                /// 获取或设置配送方式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_options")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_options")]
                public Types.DeliveryOption[]? DeliveryOptionIdList { get; set; }

                /// <summary>
                /// 获取或设置制造商信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("manufacturer")]
                [System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
                public Types.Manufacturer? Manufacturer { get; set; }

                /// <summary>
                /// 获取或设置审核失败原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_failed_reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_failed_reasons")]
                public Types.AuditFailedReason[]? AuditFailedReasonList { get; set; }
            }
        }
    }
}
