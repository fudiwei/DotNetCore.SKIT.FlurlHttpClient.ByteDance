using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_products 接口的请求。</para>
    /// </summary>
    public class ProductCreateGlobalProductRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Image : ProductCreateProductRequest.Types.Image
            {
            }

            public class Video : ProductCreateProductRequest.Types.Video
            {
            }

            public class SKU
            {
                public static class Types
                {
                    public class SalesAttribute : ProductCreateProductRequest.Types.SKU.Types.SalesAttribute
                    {
                        public static new class Types
                        {
                            public class Image : ProductCreateProductRequest.Types.SKU.Types.SalesAttribute.Types.Image
                            {
                            }
                        }
                    }

                    public class Price : ProductCreateProductRequest.Types.SKU.Types.Price
                    {
                    }

                    public class Inventory
                    {
                        /// <summary>
                        /// 获取或设置全球仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("global_warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("global_warehouse_id")]
                        public string WarehouseId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置库存数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }
                    }

                    public class IdentifierCode : ProductCreateProductRequest.Types.SKU.Types.IdentifierCode
                    {
                    }
                }

                /// <summary>
                /// 获取或设置销售属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales_attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                public IList<Types.SalesAttribute>? SalesAttributeList { get; set; }

                /// <summary>
                /// 获取或设置库存列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inventory")]
                [System.Text.Json.Serialization.JsonPropertyName("inventory")]
                public IList<Types.Inventory>? InventoryList { get; set; }

                /// <summary>
                /// 获取或设置价格信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public Types.Price Price { get; set; } = new Types.Price();

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
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal? UnitCount { get; set; }
            }

            public class PackageDimension : ProductCreateProductRequest.Types.PackageDimension
            {
            }

            public class PackageWeight : ProductCreateProductRequest.Types.PackageWeight
            {
            }

            public class Certification : ProductCreateProductRequest.Types.Certification
            {
                public static new class Types
                {
                    public class Image : ProductCreateProductRequest.Types.Certification.Types.Image
                    {
                    }

                    public class File : ProductCreateProductRequest.Types.Certification.Types.File
                    {
                    }
                }
            }

            public class ProductAttribute : ProductCreateProductRequest.Types.ProductAttribute
            {
                public static new class Types
                {
                    public class ProductAttributeValue : ProductCreateProductRequest.Types.ProductAttribute.Types.ProductAttributeValue
                    {
                    }
                }
            }

            public class SizeChart : ProductCreateProductRequest.Types.SizeChart
            {
                public static new class Types
                {
                    public class Image : ProductCreateProductRequest.Types.SizeChart.Types.Image
                    {
                    }

                    public class Template : ProductCreateProductRequest.Types.SizeChart.Types.Template
                    {
                    }
                }
            }

            public class Manufacturer : ProductCreateProductRequest.Types.Manufacturer
            {
            }
        }

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_id")]
        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string? BrandId { get; set; }

        /// <summary>
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("main_images")]
        [System.Text.Json.Serialization.JsonPropertyName("main_images")]
        public IList<Types.Image>? MainImageList { get; set; }

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
        public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();

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
        public IList<Types.Certification>? CertificationList { get; set; }

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_attributes")]
        [System.Text.Json.Serialization.JsonPropertyName("product_attributes")]
        public IList<Types.ProductAttribute>? ProductAttributeList { get; set; }

        /// <summary>
        /// 获取或设置制造商信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manufacturer")]
        [System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
        public Types.Manufacturer? Manufacturer { get; set; }
    }
}
