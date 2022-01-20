using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/editV2 接口的请求。</para>
    /// </summary>
    public class ProductEditV2Request : TikTokShopRequest
    {
        public class Types
        {
            public class Specification : ProductAddV2Request.Types.Specification
            {
            }

            public class SpecificationPrice : ProductAddV2Request.Types.SpecificationPrice
            {
            }

            public class Qualification : ProductAddV2Request.Types.Qualification
            {
            }
        }

        internal static class Converters
        {
            internal class NewtonsoftJsonQulificationListConverter : ProductAddV2Request.Converters.NewtonsoftJsonQulificationListConverter
            {
            }

            internal class SystemTextJsonQulificationListConverter : ProductAddV2Request.Converters.SystemTextJsonQulificationListConverter
            {
            }

            internal class NewtonsoftJsonSpecificationListConverter : ProductAddV2Request.Converters.NewtonsoftJsonSpecificationListConverter
            {
            }

            internal class SystemTextJsonSpecificationListConverter : ProductAddV2Request.Converters.SystemTextJsonSpecificationListConverter
            {
            }

            internal class NewtonsoftJsonSpecificationPriceListConverter : ProductAddV2Request.Converters.NewtonsoftJsonSpecificationPriceListConverter
            {
            }

            internal class SystemTextJsonSpecificationPriceListConverter : ProductAddV2Request.Converters.SystemTextJsonSpecificationPriceListConverter
            {
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableLongConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置外部商品编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outer_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("outer_product_id")]
        public string? OuterProductId { get; set; }

        /// <summary>
        /// 获取或设置商品名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置详情 HTML。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int ProductType { get; set; }

        /// <summary>
        /// 获取或设置划线价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("market_price")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? MarketPrice { get; set; }

        /// <summary>
        /// 获取或设置售价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_price")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("discount_price")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? DiscountPrice { get; set; }

        /// <summary>
        /// 获取或设置客服手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置叶子类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_leaf_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("category_leaf_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? CategoryLeafId { get; set; }

        /// <summary>
        /// 获取或设置一级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_cid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? FirstCategoryId { get; set; }

        /// <summary>
        /// 获取或设置二级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_cid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? SecondCategoryId { get; set; }

        /// <summary>
        /// 获取或设置三级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_cid")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? ThirdCategoryId { get; set; }

        /// <summary>
        /// 获取或设置支持的支付方式类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? PayType { get; set; }

        /// <summary>
        /// 获取或设置商品主图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pic")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string>? PictureUrlList { get; set; }

        /// <summary>
        /// 获取或设置商品属性。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_format")]
        [System.Text.Json.Serialization.JsonPropertyName("product_format")]
        public string? ProductFormat { get; set; }

        /// <summary>
        /// 获取或设置商家推荐语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommend_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("recommend_remark")]
        public string? RecommendRemark { get; set; }

        /// <summary>
        /// 获取或设置减库存类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reduce_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("reduce_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? ReduceType { get; set; }

        /// <summary>
        /// 获取或设置同店推荐商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("assoc_ids")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("assoc_ids")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string>? AssociateProductIdList { get; set; }

        /// <summary>
        /// 获取或设置运费模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("freight_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("freight_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? FreightId { get; set; }

        /// <summary>
        /// 获取或设置重量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? Weight { get; set; }

        /// <summary>
        /// 获取或设置重量单位类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight_unit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("weight_unit")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? WeightUnit { get; set; }

        /// <summary>
        /// 获取或设置承诺发货时间（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_delay_day")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_delay_day")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? DeliveryDelayDay { get; set; }

        /// <summary>
        /// 获取或设置预售模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presell_type")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("presell_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? PresellType { get; set; }

        /// <summary>
        /// 获取或设置预售发货时间（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presell_delay")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("presell_delay")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? PresellDelay { get; set; }

        /// <summary>
        /// 获取或设置预售结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presell_end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("presell_end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? PresellEndTime { get; set; }

        /// <summary>
        /// 获取或设置 7 天无理由退货类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supply_7day_return")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("supply_7day_return")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? Supply7DayReturnType { get; set; }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int? BrandId { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark")]
        [System.Text.Json.Serialization.JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置质检报告 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quality_report")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("quality_report")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string>? QualityReportUrlList { get; set; }

        /// <summary>
        /// 获取或设置品类资质 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("class_quality")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("class_quality")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string>? ClassQualificationUrlList { get; set; }

        /// <summary>
        /// 获取或设置商品资质列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quality_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonQulificationListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("quality_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonQulificationListConverter))]
        public IList<Types.Qualification>? QualificationList { get; set; }

        /// <summary>
        /// 获取或设置规格名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spec_name")]
        [System.Text.Json.Serialization.JsonPropertyName("spec_name")]
        public string? SpecificationName { get; set; }

        /// <summary>
        /// 获取或设置规格列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specs")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonSpecificationListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("specs")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonSpecificationListConverter))]
        public IList<Types.Specification> SpecificationList { get; set; } = new List<Types.Specification>();

        /// <summary>
        /// 获取或设置规格详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spec_prices")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.NewtonsoftJsonSpecificationPriceListConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("spec_prices")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.SystemTextJsonSpecificationPriceListConverter))]
        public IList<Types.SpecificationPrice> SpecificationPriceList { get; set; } = new List<Types.SpecificationPrice>();

        /// <summary>
        /// 获取或设置规格图片 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spec_pic")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("spec_pic")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithCommaSplitConverter))]
        public IList<string>? SpecificationPictureUrlList { get; set; }

        /// <summary>
        /// 获取或设置每笔订单最多限购件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maximum_per_order")]
        [System.Text.Json.Serialization.JsonPropertyName("maximum_per_order")]
        public int? MaximumPerOrder { get; set; }

        /// <summary>
        /// 获取或设置每笔订单最少购买件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minimum_per_order")]
        [System.Text.Json.Serialization.JsonPropertyName("minimum_per_order")]
        public int? MinimumPerOrder { get; set; }

        /// <summary>
        /// 获取或设置每个用户累计限购件数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit_per_buyer")]
        [System.Text.Json.Serialization.JsonPropertyName("limit_per_buyer")]
        public int? LimitPerBuyer { get; set; }

        /// <summary>
        /// 获取或设置是否提审。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("commit")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
        public bool IsCommitting { get; set; }
    }
}
