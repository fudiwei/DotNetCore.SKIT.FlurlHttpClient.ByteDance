using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /product/global_products 接口的请求。</para>
    /// </summary>
    public class GlobalProductUpdateProductRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Image : GlobalProductCreateProductRequest.Types.Image
            {
            }

            public class SizeChart : GlobalProductCreateProductRequest.Types.SizeChart
            {
            }

            public class ProductCertification : GlobalProductCreateProductRequest.Types.ProductCertification
            {
                public static new class Types
                {
                    public class Image : GlobalProductCreateProductRequest.Types.ProductCertification.Types.Image
                    {
                    }

                    public class File : GlobalProductCreateProductRequest.Types.ProductCertification.Types.File
                    {
                    }
                }

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("images")]
                [System.Text.Json.Serialization.JsonPropertyName("images")]
                public new IList<Types.Image>? ImageList { get; set; }

                /// <summary>
                /// 获取或设置文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("files")]
                [System.Text.Json.Serialization.JsonPropertyName("files")]
                public new IList<Types.File>? FileList { get; set; }
            }

            public class GlobalSKU : GlobalProductCreateProductRequest.Types.GlobalSKU
            {
                public static new class Types
                {
                    public class SalesAttribute : GlobalProductCreateProductRequest.Types.GlobalSKU.Types.SalesAttribute
                    {
                        public static new class Types
                        {
                            public class Image : GlobalProductCreateProductRequest.Types.GlobalSKU.Types.SalesAttribute.Types.Image
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置图片信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_img")]
                        public new Types.Image? Image { get; set; }
                    }

                    public class IdentifierCodeInfo : GlobalProductCreateProductRequest.Types.GlobalSKU.Types.IdentifierCodeInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置全球 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string? GlobalSKUId { get; set; }

                /// <summary>
                /// 获取或设置原价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_price")]
                public new decimal OriginalPrice { get { return base.OriginalPrice; } set { base.OriginalPrice = value; } }

                /// <summary>
                /// 获取或设置销售属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales_attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                public new IList<Types.SalesAttribute>? SalesAttributeList { get; set; }

                /// <summary>
                /// 获取或设置产品标识码信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_identifier_code")]
                [System.Text.Json.Serialization.JsonPropertyName("product_identifier_code")]
                public new Types.IdentifierCodeInfo? IdentifierCodeInfo { get; set; }
            }

            public class ProductAttribute : GlobalProductCreateProductRequest.Types.ProductAttribute
            {
                public static new class Types
                {
                    public class ProductAttributeValue : GlobalProductCreateProductRequest.Types.ProductAttribute.Types.ProductAttributeValue
                    {
                    }
                }

                /// <summary>
                /// 获取或设置属性值列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attribute_values")]
                [System.Text.Json.Serialization.JsonPropertyName("attribute_values")]
                public new IList<Types.ProductAttributeValue> ValueList { get; set; } = new List<Types.ProductAttributeValue>();
            }

            public class ExemptionOfIdentifierCode : GlobalProductCreateProductRequest.Types.ExemptionOfIdentifierCode
            {
            }
        }

        /// <summary>
        /// 获取或设置全球商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("global_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("global_product_id")]
        public string GlobalProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
        public string ProductName { get; set; } = string.Empty;

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
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public IList<Types.Image>? ImageList { get; set; }

        /// <summary>
        /// 获取或设置质保期 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warranty_period")]
        [System.Text.Json.Serialization.JsonPropertyName("warranty_period")]
        public int? WarrantyPeriodId { get; set; }

        /// <summary>
        /// 获取或设置质保政策。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warranty_policy")]
        [System.Text.Json.Serialization.JsonPropertyName("warranty_policy")]
        public string? WarrantyPolicy { get; set; }

        /// <summary>
        /// 获取或设置包装长度（单位：厘米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_length")]
        [System.Text.Json.Serialization.JsonPropertyName("package_length")]
        public int? PackageLength { get; set; }

        /// <summary>
        /// 获取或设置包装宽度（单位：厘米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_width")]
        [System.Text.Json.Serialization.JsonPropertyName("package_width")]
        public int? PackageWidth { get; set; }

        /// <summary>
        /// 获取或设置包装高度（单位：厘米）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_height")]
        [System.Text.Json.Serialization.JsonPropertyName("package_height")]
        public int? PackageHeight { get; set; }

        /// <summary>
        /// 获取或设置包装重量（单位：千克）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_weight")]
        [System.Text.Json.Serialization.JsonPropertyName("package_weight")]
        public int? PackageWeight { get; set; }

        /// <summary>
        /// 获取或设置包装尺寸单位。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package_dimension_unit")]
        [System.Text.Json.Serialization.JsonPropertyName("package_dimension_unit")]
        public string? PackageDimensionUnit { get; set; }

        /// <summary>
        /// 获取或设置尺码表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size_chart")]
        [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
        public Types.SizeChart? SizeChart { get; set; }

        /// <summary>
        /// 获取或设置全球 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.GlobalSKU>? GlobalSKUList { get; set; }

        /// <summary>
        /// 获取或设置商品认证列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_certifications")]
        [System.Text.Json.Serialization.JsonPropertyName("product_certifications")]
        public IList<Types.ProductCertification>? ProductCertificationList { get; set; }

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_attributes")]
        [System.Text.Json.Serialization.JsonPropertyName("product_attributes")]
        public IList<Types.ProductAttribute>? ProductAttributeList { get; set; }

        /// <summary>
        /// 获取或设置产品标识码豁免信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exemption_of_identifier_code")]
        [System.Text.Json.Serialization.JsonPropertyName("exemption_of_identifier_code")]
        public Types.ExemptionOfIdentifierCode? ExemptionOfIdentifierCode { get; set; }
    }
}
