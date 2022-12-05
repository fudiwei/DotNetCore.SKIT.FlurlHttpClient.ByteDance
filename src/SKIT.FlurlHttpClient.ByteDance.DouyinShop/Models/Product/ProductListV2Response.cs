using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/listV2 接口的响应。</para>
    /// </summary>
    public class ProductListV2Response : DouyinShopResponse<ProductListV2Response.Types.Data>
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
                            public class Category : ProductDetailResponse.Types.Data.Types.Category
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置外部商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                        public long OutProductId { get; set; }

                        /// <summary>
                        /// 获取或设置外部商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outer_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("outer_product_id")]
                        public string OuterProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详情 HTML。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                        public int ProductType { get; set; }

                        /// <summary>
                        /// 获取或设置划线价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("market_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                        public int MarketPrice { get; set; }

                        /// <summary>
                        /// 获取或设置售价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_price")]
                        public int DiscountPrice { get; set; }

                        /// <summary>
                        /// 获取或设置上下架状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("check_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("check_status")]
                        public int CheckStatus { get; set; }

                        /// <summary>
                        /// 获取或设置客服手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public string? MobileNumber { get; set; }

                        /// <summary>
                        /// 获取或设置规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_id")]
                        public long SpecificationId { get; set; }

                        /// <summary>
                        /// 获取或设置类目信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_detail")]
                        public Types.Category? Category { get; set; }

                        /// <summary>
                        /// 获取或设置佣金比例（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cos_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("cos_ratio")]
                        public double COSRatio { get; set; }

                        /// <summary>
                        /// 获取或设置支持的支付方式类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                        public int PayType { get; set; }

                        /// <summary>
                        /// 获取或设置商家推荐语。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recommend_remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("recommend_remark")]
                        public string RecommendRemark { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置扩展字段。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra")]
                        public string? Extra { get; set; }

                        /// <summary>
                        /// 获取或设置商品头图 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("img")]
                        [System.Text.Json.Serialization.JsonPropertyName("img")]
                        public string ImageUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是组套商品。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_package_product")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_package_product")]
                        public bool IsPackageProduct { get; set; }

                        /// <summary>
                        /// 获取或设置关联的组套主商品 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("package_product_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("package_product_list")]
                        public string[]? PackageProductIdList { get; set; }

                        /// <summary>
                        /// 获取或设置关联的组套子商品 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_product_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_product_list")]
                        public string[]? SubProductIdList { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampDateTimeOffsetConverter))]
                        public DateTimeOffset UpdateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Product[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品总数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置翻页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page")]
                [System.Text.Json.Serialization.JsonPropertyName("page")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置翻页每页数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int PageSize { get; set; }
            }
        }
    }
}
