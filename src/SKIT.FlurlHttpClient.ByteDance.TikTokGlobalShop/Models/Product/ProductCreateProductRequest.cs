using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products 接口的请求。</para>
    /// </summary>
    public class ProductCreateProductRequest : TikTokShopRequest
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
                public string Uri { get; set; } = string.Empty;
            }

            public class Video
            {
                /// <summary>
                /// 获取或设置文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string FileId { get; set; } = string.Empty;
            }

            public class SKU
            {
                public static class Types
                {
                    public class SalesAttribute
                    {
                        public static class Types
                        {
                            public class Image : ProductCreateProductRequest.Types.Image
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string AttributeId { get; set; } = string.Empty;

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
                        public string Currency { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public decimal Amount { get; set; }
                    }

                    public class Inventory
                    {
                        /// <summary>
                        /// 获取或设置仓库 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warehouse_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                        public string WarehouseId { get; set; } = string.Empty;

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
                        public string Type { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置标识码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string Code { get; set; } = string.Empty;
                    }

                    public class CombinedSKU
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置 SKU 数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_count")]
                        public int SKUCount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置外部 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("external_sku_id")]
                public string? ExternalSKUId { get; set; }

                /// <summary>
                /// 获取或设置外部 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_url")]
                [System.Text.Json.Serialization.JsonPropertyName("external_url")]
                public string? ExternalUrl { get; set; }

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
                /// 获取或设置组合 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("combined_skus")]
                [System.Text.Json.Serialization.JsonPropertyName("combined_skus")]
                public IList<Types.CombinedSKU>? CombinedSKUList { get; set; }

                /// <summary>
                /// 获取或设置 SKU 单位数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_unit_count")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("sku_unit_count")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal? UnitCount { get; set; }
            }

            public class PackageDimension
            {
                /// <summary>
                /// 获取或设置长度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("length")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("length")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal Length { get; set; }

                /// <summary>
                /// 获取或设置宽度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal Width { get; set; }

                /// <summary>
                /// 获取或设置高度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("height")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal Height { get; set; }

                /// <summary>
                /// 获取或设置尺寸单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unit")]
                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                public string Unit { get; set; } = string.Empty;
            }

            public class PackageWeight
            {
                /// <summary>
                /// 获取或设置重量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal Value { get; set; }

                /// <summary>
                /// 获取或设置重量单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unit")]
                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                public string Unit { get; set; } = string.Empty;
            }

            public class Certification
            {
                public static class Types
                {
                    public class Image : ProductCreateProductRequest.Types.Image
                    {
                    }

                    public class File
                    {
                        /// <summary>
                        /// 获取或设置文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string FileId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置文件名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置文件格式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("format")]
                        [System.Text.Json.Serialization.JsonPropertyName("format")]
                        public string? Format { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品认证 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string CertificationId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("images")]
                [System.Text.Json.Serialization.JsonPropertyName("images")]
                public IList<Types.Image>? ImageList { get; set; }

                /// <summary>
                /// 获取或设置文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("files")]
                [System.Text.Json.Serialization.JsonPropertyName("files")]
                public IList<Types.File>? FileList { get; set; }
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
                        public string? ValueId { get; set; }

                        /// <summary>
                        /// 获取或设置属性值名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置属性 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string AttributeId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置属性值列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("values")]
                [System.Text.Json.Serialization.JsonPropertyName("values")]
                public IList<Types.ProductAttributeValue> ValueList { get; set; } = new List<Types.ProductAttributeValue>();
            }

            public class SizeChart
            {
                public static class Types
                {
                    public class Image : ProductCreateProductRequest.Types.Image
                    {
                    }

                    public class Template
                    {
                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string TemplateId { get; set; } = string.Empty;
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
        }

        /// <summary>
        /// 获取或设置保存模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("save_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("save_mode")]
        public string? SaveMode { get; set; }

        /// <summary>
        /// 获取或设置外部商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("external_product_id")]
        public string? ExternalProductId { get; set; }

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
        /// 获取或设置组合商品主商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("primary_combined_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("primary_combined_product_id")]
        public string? PrimaryCombinedProductId { get; set; }

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
        /// 获取或设置是否允许货到付款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_cod_allowed")]
        [System.Text.Json.Serialization.JsonPropertyName("is_cod_allowed")]
        public bool IsCashOnDeliveryAllowed { get; set; }

        /// <summary>
        /// 获取或设置配送方式 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_option_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_ids")]
        public IList<string>? DeliveryOptionIdList { get; set; }

        /// <summary>
        /// 获取或设置制造商信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manufacturer")]
        [System.Text.Json.Serialization.JsonPropertyName("manufacturer")]
        public Types.Manufacturer? Manufacturer { get; set; }
    }
}
