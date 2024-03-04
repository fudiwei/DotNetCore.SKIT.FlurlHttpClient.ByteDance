namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/global_products 接口的响应。</para>
    /// </summary>
    public class GlobalProductGetProductDetailResponse : TikTokShopResponse<GlobalProductGetProductDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LocalProduct
                    {
                        /// <summary>
                        /// 获取或设置店铺所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置本地商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string LocalProductId { get; set; } = default!;
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ImageId { get; set; } = default!;
                    }

                    public class SizeChart : Data.Types.Image
                    {
                    }

                    public class GlobalSKU
                    {
                        public static class Types
                        {
                            public class SalesAttribute
                            {
                                public static class Types
                                {
                                    public class Image : Data.Types.Image
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置属性 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attribute_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("attribute_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string AttributeId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("attribute_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("attribute_name")]
                                public string AttributeName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置自定义属性值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("custom_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("custom_value")]
                                public string? CustomValue { get; set; }

                                /// <summary>
                                /// 获取或设置图片信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_img")]
                                public Types.Image? Image { get; set; }
                            }

                            public class StockInfo
                            {
                                /// <summary>
                                /// 获取或设置可用库存。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("available_stock")]
                                [System.Text.Json.Serialization.JsonPropertyName("available_stock")]
                                public int AvailableStock { get; set; }
                            }

                            public class IdentifierCodeInfo : ProductGetProductDetailResponse.Types.Data.Types.SKU.Types.IdentifierCodeInfo
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置全球 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string GlobalSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                        public string? SellerSKU { get; set; }

                        /// <summary>
                        /// 获取或设置原价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal OriginalPrice { get; set; }

                        /// <summary>
                        /// 获取或设置销售属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                        public Types.SalesAttribute[]? SalesAttributeList { get; set; }

                        /// <summary>
                        /// 获取或设置库存信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_info")]
                        public Types.StockInfo StockInfo { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置产品标识码信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_identifier_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_identifier_code")]
                        public Types.IdentifierCodeInfo? IdentifierCodeInfo { get; set; }
                    }

                    public class ProductCertification
                    {
                        public static class Types
                        {
                            public class Image : Data.Types.Image
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
                                public string FileName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置文件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string FileType { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品认证 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string CertificationId { get; set; } = default!;

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
                                [Newtonsoft.Json.JsonProperty("value_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                                public string ValueName { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string AttributeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attribute_values")]
                        [System.Text.Json.Serialization.JsonPropertyName("attribute_values")]
                        public Types.ProductAttributeValue[] ValueList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置全球商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("global_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("global_product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string GlobalProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置本地商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("local_products")]
                [System.Text.Json.Serialization.JsonPropertyName("local_products")]
                public Types.LocalProduct[] LocalProduct { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_name")]
                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                public string ProductName { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_status")]
                [System.Text.Json.Serialization.JsonPropertyName("product_status")]
                public int ProductStatus { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;

                /// <summary>
                /// 获取或设置分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string CategoryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("images")]
                [System.Text.Json.Serialization.JsonPropertyName("images")]
                public Types.Image[] ImageList { get; set; } = default!;

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
                public int PackageLength { get; set; }

                /// <summary>
                /// 获取或设置包装宽度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_width")]
                [System.Text.Json.Serialization.JsonPropertyName("package_width")]
                public int PackageWidth { get; set; }

                /// <summary>
                /// 获取或设置包装高度（单位：厘米）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_height")]
                [System.Text.Json.Serialization.JsonPropertyName("package_height")]
                public int PackageHeight { get; set; }

                /// <summary>
                /// 获取或设置包装重量（单位：千克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_weight")]
                [System.Text.Json.Serialization.JsonPropertyName("package_weight")]
                public int PackageWeight { get; set; }

                /// <summary>
                /// 获取或设置包装尺寸单位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_dimension_unit")]
                [System.Text.Json.Serialization.JsonPropertyName("package_dimension_unit")]
                public string PackageDimensionUnit { get; set; } = default!;

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
                public Types.GlobalSKU[]? GlobalSKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品认证列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_certifications")]
                [System.Text.Json.Serialization.JsonPropertyName("product_certifications")]
                public Types.ProductCertification[]? ProductCertificationList { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_attributes")]
                [System.Text.Json.Serialization.JsonPropertyName("product_attributes")]
                public Types.ProductAttribute[]? ProductAttributeList { get; set; }

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
            }
        }
    }
}
