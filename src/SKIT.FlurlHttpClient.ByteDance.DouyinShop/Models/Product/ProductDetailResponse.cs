using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/detail 接口的响应。</para>
    /// </summary>
    public class ProductDetailResponse : DouyinShopResponse<ProductDetailResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
                        public int FirstCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
                        public int SecondCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
                        public int ThirdCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置四级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fourth_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("fourth_cid")]
                        public int ForthCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置一级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_cname")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_cname")]
                        public string? FirstCategoryName { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_cname")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_cname")]
                        public string? SecondCategoryName { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_cname")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_cname")]
                        public string? ThirdCategoryName { get; set; }

                        /// <summary>
                        /// 获取或设置四级类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fourth_cname")]
                        [System.Text.Json.Serialization.JsonPropertyName("fourth_cname")]
                        public string? ForthCategoryName { get; set; }
                    }

                    public class SpecificationPicture
                    {
                        /// <summary>
                        /// 获取或设置规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id")]
                        public long SpecificationDetailId { get; set; }

                        /// <summary>
                        /// 获取或设置图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic")]
                        public string PictureUrl { get; set; } = default!;
                    }

                    public class SpecificationPrice
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置外部 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                        public long OutSKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 商家编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("outer_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("outer_sku_id")]
                        public string OuterSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU Code。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("code")]
                        [System.Text.Json.Serialization.JsonPropertyName("code")]
                        public string SKUCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_type")]
                        public int SKUType { get; set; }

                        /// <summary>
                        /// 获取或设置规格 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_ids")]
                        public long[] SpecificationDetailId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置一级规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id1")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id1")]
                        public long SpecificationDetailId1 { get; set; }

                        /// <summary>
                        /// 获取或设置二级规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id2")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id2")]
                        public long SpecificationDetailId2 { get; set; }

                        /// <summary>
                        /// 获取或设置三级规格 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_detail_id3")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_detail_id3")]
                        public long SpecificationDetailId3 { get; set; }

                        /// <summary>
                        /// 获取或设置价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置结算价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_price")]
                        public int SettlementPrice { get; set; }

                        /// <summary>
                        /// 获取或设置库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                        public int StockNumber { get; set; }

                        /// <summary>
                        /// 获取或设置阶梯库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("step_stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("step_stock_num")]
                        public int StepStockNumber { get; set; }

                        /// <summary>
                        /// 获取或设置活动库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prom_stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("prom_stock_num")]
                        public int PromotionStockNumber { get; set; }

                        /// <summary>
                        /// 获取或设置活动阶梯库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("prom_step_stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("prom_step_stock_num")]
                        public int PromotionStepStockNumber { get; set; }

                        /// <summary>
                        /// 获取或设置锁定库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lock_stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("lock_stock_num")]
                        public int LockStockNumber { get; set; }

                        /// <summary>
                        /// 获取或设置锁定阶梯库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("lock_step_stock_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("lock_step_stock_num")]
                        public int LockStepStockNumber { get; set; }

                        /// <summary>
                        /// 获取或设置区域仓库存信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_num_map")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_num_map")]
                        public IDictionary<string, int>? StockMap { get; set; }

                        /// <summary>
                        /// 获取或设置供应商 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supplier_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string? SupplierId { get; set; }
                    }

                    public class Specification
                    {
                        /// <summary>
                        /// 获取或设置 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long Id { get; set; }

                        /// <summary>
                        /// 获取或设置上级 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pid")]
                        [System.Text.Json.Serialization.JsonPropertyName("pid")]
                        public long ParentID { get; set; }

                        /// <summary>
                        /// 获取或设置规格组 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("spec_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("spec_id")]
                        public long SpecificationId { get; set; }

                        /// <summary>
                        /// 获取或设置规格名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否是子节点。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_leaf")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("is_leaf")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool IsLeaf { get; set; }

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置子节点。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("values")]
                        [System.Text.Json.Serialization.JsonPropertyName("values")]
                        public Specification[]? Values { get; set; }
                    }

                    public class Logistics
                    {
                        /// <summary>
                        ///
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customs_clear_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("customs_clear_type")]
                        public int CustomsClearType { get; set; }

                        /// <summary>
                        ///
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("origin_region_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("origin_region_id")]
                        public int OriginRegionId { get; set; }

                        /// <summary>
                        ///
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("source_region_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("source_region_id")]
                        public int SourceRegionId { get; set; }

                        /// <summary>
                        ///
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_region_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_region_id")]
                        public int BrandRegionId { get; set; }

                        /// <summary>
                        ///
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tax_payer")]
                        [System.Text.Json.Serialization.JsonPropertyName("tax_payer")]
                        public int TaxPayer { get; set; }

                        /// <summary>
                        ///
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("net_weight_qty")]
                        [System.Text.Json.Serialization.JsonPropertyName("net_weight_qty")]
                        public int NetWeightQuantity { get; set; }
                    }

                    public class Qualification
                    {
                        public static class Types
                        {
                            public class Attachment
                            {
                                /// <summary>
                                /// 获取或设置附件类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("media_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("media_type")]
                                public int MediaType { get; set; }

                                /// <summary>
                                /// 获取或设置附件 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置 Key。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quality_key")]
                        [System.Text.Json.Serialization.JsonPropertyName("quality_key")]
                        public string Key { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quality_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("quality_name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置附件列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quality_attachments")]
                        [System.Text.Json.Serialization.JsonPropertyName("quality_attachments")]
                        public Types.Attachment[] AttachmentList { get; set; } = default!;
                    }

                    public class AftersaleService
                    {
                        /// <summary>
                        /// 获取或设置 7 天无理由退货类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("supply_7day_return")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("supply_7day_return")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public int Supply7DayReturnType { get; set; }
                    }
                }

                internal static class Converters
                {
                    internal class NewtonsoftJsonAftersaleServiceConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.AftersaleService?>
                    {
                    }

                    internal class SystemTextJsonAftersaleServiceConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.AftersaleService?>
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
                /// 获取或设置商品 ID 字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id_str")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id_str")]
                public string ProductIdString { get; set; } = default!;

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
                /// 获取或设置规格列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("specs")]
                [System.Text.Json.Serialization.JsonPropertyName("specs")]
                public Types.Specification[] SpecificationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置规格图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_pics")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_pics")]
                public Types.SpecificationPicture[] SpecificationPictureList { get; set; } = default!;

                /// <summary>
                /// 获取或设置规格详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_prices")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_prices")]
                public Types.SpecificationPrice[] SpecificationPriceList { get; set; } = default!;

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
                public int SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_cid")]
                [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
                public int ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("category_detail")]
                public Types.Category? Category { get; set; }

                /// <summary>
                /// 获取或设置支持的支付方式类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                public int PayType { get; set; }

                /// <summary>
                /// 获取或设置预售类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("presell_type")]
                [System.Text.Json.Serialization.JsonPropertyName("presell_type")]
                public int PresellType { get; set; }

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
                /// 获取或设置商品主图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pic")]
                [System.Text.Json.Serialization.JsonPropertyName("pic")]
                public string[] PictureUrlList { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品属性。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_format")]
                [System.Text.Json.Serialization.JsonPropertyName("product_format")]
                public string ProductFormat { get; set; } = default!;

                /// <summary>
                /// 获取或设置每笔订单最多限购件数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("maximum_per_order")]
                [System.Text.Json.Serialization.JsonPropertyName("maximum_per_order")]
                public int MaximumPerOrder { get; set; }

                /// <summary>
                /// 获取或设置每笔订单最少购买件数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("minimum_per_order")]
                [System.Text.Json.Serialization.JsonPropertyName("minimum_per_order")]
                public int MinimumPerOrder { get; set; }

                /// <summary>
                /// 获取或设置每个用户累计限购件数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_per_buyer")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_per_buyer")]
                public int LimitPerBuyer { get; set; }

                /// <summary>
                /// 获取或设置商品资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quality_list")]
                [System.Text.Json.Serialization.JsonPropertyName("quality_list")]
                public Types.Qualification[] QualificationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置物流信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logistics_info")]
                [System.Text.Json.Serialization.JsonPropertyName("logistics_info")]
                public Types.Logistics? Logistics { get; set; }

                /// <summary>
                /// 获取或设置售后服务信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_service")]
                [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonAftersaleServiceConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_service")]
                [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonAftersaleServiceConverter))]
                public Types.AftersaleService? AftersaleService { get; set; }

                /// <summary>
                /// 获取或设置是否是组套商品的子商品。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_sub_product")]
                [System.Text.Json.Serialization.JsonPropertyName("is_sub_product")]
                public bool IsSubProduct { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset UpdateTime { get; set; }

                /// <summary>
                /// 获取或设置草稿状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("draft_status")]
                [System.Text.Json.Serialization.JsonPropertyName("draft_status")]
                public int DraftStatue { get; set; }
            }
        }
    }
}
