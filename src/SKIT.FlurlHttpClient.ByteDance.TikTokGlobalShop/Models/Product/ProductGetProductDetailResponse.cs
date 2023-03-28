namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/details 接口的响应。</para>
    /// </summary>
    public class ProductGetProductDetailResponse : TikTokShopResponse<ProductGetProductDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Category : ProductGetCategoryListResponse.Types.Data.Types.Category
                    {
                    }

                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置品牌 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string BrandId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string BrandName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int BrandStatus { get; set; }
                    }

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ImageId { get; set; } = default!;

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

                        /// <summary>
                        /// 获取或设置图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
                        public string[] ImageUrlList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置缩略图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("thumb_url_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("thumb_url_list")]
                        public string[]? ThumbnailUrlList { get; set; }
                    }

                    public class Video
                    {
                        public static class Types
                        {
                            public class VideoInfo
                            {
                                /// <summary>
                                /// 获取或设置主 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("main_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("main_url")]
                                public string MainUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置备用 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("backup_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("backup_url")]
                                public string BackupUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 URL 过期时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url_expire")]
                                [System.Text.Json.Serialization.JsonPropertyName("url_expire")]
                                public long UrlExpireTimestamp { get; set; }

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
                                public int FileSize { get; set; }

                                /// <summary>
                                /// 获取或设置文件哈希值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("file_hash")]
                                [System.Text.Json.Serialization.JsonPropertyName("file_hash")]
                                public string FileHash { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置格式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("format")]
                                [System.Text.Json.Serialization.JsonPropertyName("format")]
                                public string Format { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置比特率。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("bitrate")]
                                [System.Text.Json.Serialization.JsonPropertyName("bitrate")]
                                public int BitRate { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置文件 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string FileId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("duration")]
                        public int Duration { get; set; }

                        /// <summary>
                        /// 获取或设置视频封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("post_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("post_url")]
                        public string PosterUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频媒体类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("media_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("media_type")]
                        public string MediaType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_infos")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_infos")]
                        public Types.VideoInfo[]? VideoInfoList { get; set; }
                    }

                    public class WarrantyPeriod
                    {
                        /// <summary>
                        /// 获取或设置质保期 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warranty_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("warranty_id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置质保期描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("warranty_description")]
                        [System.Text.Json.Serialization.JsonPropertyName("warranty_description")]
                        public string Description { get; set; } = default!;
                    }

                    public class SizeChart : Data.Types.Image
                    {
                    }

                    public class DeliveryService
                    {
                        /// <summary>
                        /// 获取或设置配送服务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_service_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_service_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string DeliveryServiceId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送方式名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_option_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_option_name")]
                        public string DeliveryOptionName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置配送服务状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_service_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_service_status")]
                        public bool DeliveryServiceStatus { get; set; }
                    }

                    public class SKU
                    {
                        public static class Types
                        {
                            public class PriceInfo : ProductSearchProductsResponse.Types.Data.Types.Product.Types.SKU.Types.PriceInfo
                            {
                            }

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
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string AttributeId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string AttributeName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                                public string ValueName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图片信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_img")]
                                public Types.Image? Image { get; set; }
                            }

                            public class StockInfo : ProductSearchProductsResponse.Types.Data.Types.Product.Types.SKU.Types.StockInfo
                            {
                            }

                            public class IdentifierCodeInfo
                            {
                                /// <summary>
                                /// 获取或设置标识码类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("identifier_code_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("identifier_code_type")]
                                public int IdentifierCodeType { get; set; }

                                /// <summary>
                                /// 获取或设置标识码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("identifier_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("identifier_code")]
                                public string IdentifierCode { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                        public string? SellerSKU { get; set; }

                        /// <summary>
                        /// 获取或设置销售属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                        public Types.SalesAttribute[]? SalesAttributeList { get; set; }

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

                                /// <summary>
                                /// 获取或设置文件 URL 列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("list")]
                                [System.Text.Json.Serialization.JsonPropertyName("list")]
                                public string[] FileUrlList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品认证 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string CertificationId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品认证名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string CertificationName { get; set; } = default!;

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
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string ValueName { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置属性 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string AttributeId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string AttributeName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置属性值列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public Types.ProductAttributeValue[] ValueList { get; set; } = default!;
                    }

                    public class ExemptionOfIdentifierCode
                    {
                        /// <summary>
                        /// 获取或设置 GTIN 豁免原因类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("exemption_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("exemption_reason")]
                        public int? ExemptionReasonType { get; set; }
                    }

                    public class QCReason
                    {
                        /// <summary>
                        /// 获取或设置原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }

                        /// <summary>
                        /// 获取或设置子项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_reasons")]
                        public string[]? SubReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string ProductId { get; set; } = default!;

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
                /// 获取或设置分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_list")]
                [System.Text.Json.Serialization.JsonPropertyName("category_list")]
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
                [Newtonsoft.Json.JsonProperty("images")]
                [System.Text.Json.Serialization.JsonPropertyName("images")]
                public Types.Image[] ImageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public Types.Video? Video { get; set; }

                /// <summary>
                /// 获取或设置质保期信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warranty_period")]
                [System.Text.Json.Serialization.JsonPropertyName("warranty_period")]
                public Types.WarrantyPeriod? WarrantyPeriod { get; set; }

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
                /// 获取或设置是否开启货到付款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_cod_open")]
                [System.Text.Json.Serialization.JsonPropertyName("is_cod_open")]
                public bool IsCashOnDeliveryOpen { get; set; }

                /// <summary>
                /// 获取或设置配送服务列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_services")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_services")]
                public Types.DeliveryService[]? DeliveryServiceList { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[]? SKUList { get; set; } = default!;

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
                /// 获取或设置产品标识码豁免信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exemption_of_identifier_code")]
                [System.Text.Json.Serialization.JsonPropertyName("exemption_of_identifier_code")]
                public Types.ExemptionOfIdentifierCode? ExemptionOfIdentifierCode { get; set; }

                /// <summary>
                /// 获取或设置 QC 原因列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qc_reasons")]
                [System.Text.Json.Serialization.JsonPropertyName("qc_reasons")]
                public Types.QCReason[]? QCReasonList { get; set; }

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
