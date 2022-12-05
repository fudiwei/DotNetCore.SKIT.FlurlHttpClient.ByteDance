using System;
using System.Collections.Generic;
using System.Linq;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/addV2 接口的请求。</para>
    /// </summary>
    public class ProductAddV2Request : DouyinShopRequest
    {
        public class Types
        {
            public class Specification
            {
                /// <summary>
                /// 获取或设置规格属性。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置规格值列表。
                /// </summary>
                [Newtonsoft.Json.JsonIgnore]
                [System.Text.Json.Serialization.JsonIgnore]
                public IList<string> Values { get; set; } = new List<string>();
            }

            public class SpecificationPrice
            {
                /// <summary>
                /// 获取或设置外部 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableLongConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public long? OutSKUId { get; set; }

                /// <summary>
                /// 获取或设置 SKU 商家编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("outer_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("outer_sku_id")]
                public string? OuterSKUId { get; set; }

                /// <summary>
                /// 获取或设置 SKU Code。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public string SKUCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置一级规格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_detail_name1")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_detail_name1")]
                public string SpecificationDetailName1 { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置二级规格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_detail_name2")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_detail_name2")]
                public string SpecificationDetailName2 { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置三级规格名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spec_detail_name3")]
                [System.Text.Json.Serialization.JsonPropertyName("spec_detail_name3")]
                public string SpecificationDetailName3 { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

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
                /// 获取或设置供应商 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_id")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_id")]
                public string? SupplierId { get; set; }
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
                        public string Url { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置 Key。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quality_key")]
                [System.Text.Json.Serialization.JsonPropertyName("quality_key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quality_name")]
                [System.Text.Json.Serialization.JsonPropertyName("quality_name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置附件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quality_attachments")]
                [System.Text.Json.Serialization.JsonPropertyName("quality_attachments")]
                public IList<Types.Attachment> AttachmentList { get; set; } = new List<Types.Attachment>();
            }
        }

        internal static class Converters
        {
            internal class NewtonsoftJsonQulificationListConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Qualification>?>
            {
            }

            internal class SystemTextJsonQulificationListConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Qualification>?>
            {
            }

            internal class NewtonsoftJsonSpecificationListConverter : Newtonsoft.Json.JsonConverter<IList<Types.Specification>?>
            {
                private const char SEPARATOR = '^';
                private const char SEPARATOR_NAME = '|';
                private const char SEPARATOR_VALUE = ',';

                public override bool CanRead
                {
                    get { return true; }
                }

                public override bool CanWrite
                {
                    get { return true; }
                }

                public override IList<Types.Specification>? ReadJson(Newtonsoft.Json.JsonReader reader, Type objectType, IList<Types.Specification>? existingValue, bool hasExistingValue, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
                    {
                        return existingValue;
                    }
                    else if (reader.TokenType == Newtonsoft.Json.JsonToken.String)
                    {
                        string? value = serializer.Deserialize<string>(reader);
                        if (value == null)
                            return existingValue;

                        return value
                            .Split(SEPARATOR)
                            .Select(e =>
                            {
                                string[] arr = e.Split(SEPARATOR_NAME);
                                return new Types.Specification()
                                {
                                    Name = arr[0],
                                    Values = arr.Length >= 2 ? arr[1].Split(SEPARATOR_VALUE).ToList() : new List<string>()
                                };
                            })
                            .ToList();
                    }

                    throw new Newtonsoft.Json.JsonReaderException();
                }

                public override void WriteJson(Newtonsoft.Json.JsonWriter writer, IList<Types.Specification>? value, Newtonsoft.Json.JsonSerializer serializer)
                {
                    if (value != null)
                        writer.WriteValue(string.Join(SEPARATOR.ToString(), value.Select(e => $"{e.Name}{SEPARATOR_NAME}{string.Join(SEPARATOR_VALUE.ToString(), e.Values)}")));
                    else
                        writer.WriteNull();
                }
            }

            internal class SystemTextJsonSpecificationListConverter : System.Text.Json.Serialization.JsonConverter<IList<Types.Specification>?>
            {
                private const char SEPARATOR = '^';
                private const char SEPARATOR_NAME = '|';
                private const char SEPARATOR_VALUE = ',';

                public override IList<Types.Specification>? Read(ref System.Text.Json.Utf8JsonReader reader, Type typeToConvert, System.Text.Json.JsonSerializerOptions options)
                {
                    if (reader.TokenType == System.Text.Json.JsonTokenType.Null)
                    {
                        return null;
                    }
                    else if (reader.TokenType == System.Text.Json.JsonTokenType.String)
                    {
                        string? value = reader.GetString();
                        if (value == null)
                            return null;

                        return value
                            .Split(SEPARATOR)
                            .Select(e =>
                            {
                                string[] arr = e.Split(SEPARATOR_NAME);
                                return new Types.Specification()
                                {
                                    Name = arr[0],
                                    Values = arr.Length >= 2 ? arr[1].Split(SEPARATOR_VALUE).ToList() : new List<string>()
                                };
                            })
                            .ToList();
                    }

                    throw new System.Text.Json.JsonException();
                }

                public override void Write(System.Text.Json.Utf8JsonWriter writer, IList<Types.Specification>? value, System.Text.Json.JsonSerializerOptions options)
                {
                    if (value != null)
                        writer.WriteStringValue(string.Join(SEPARATOR.ToString(), value.Select(e => $"{e.Name}{SEPARATOR_NAME}{string.Join(SEPARATOR_VALUE.ToString(), e.Values)}")));
                    else
                        writer.WriteNullValue();
                }
            }

            internal class NewtonsoftJsonSpecificationPriceListConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.SpecificationPrice>?>
            {
            }

            internal class SystemTextJsonSpecificationPriceListConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.SpecificationPrice>?>
            {
            }
        }

        /// <summary>
        /// 获取或设置外部商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_product_id")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualNullableLongConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public long? OutProductId { get; set; }

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
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置详情 HTML。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("market_price")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int MarketPrice { get; set; }

        /// <summary>
        /// 获取或设置售价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("discount_price")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("discount_price")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int DiscountPrice { get; set; }

        /// <summary>
        /// 获取或设置客服手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mobile")]
        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
        public string MobileNumber { get; set; } = string.Empty;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int PayType { get; set; }

        /// <summary>
        /// 获取或设置商品主图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualStringListWithPipeSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("pic")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualStringListWithPipeSplitConverter))]
        public IList<string> PictureUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品属性。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_format")]
        [System.Text.Json.Serialization.JsonPropertyName("product_format")]
        public string ProductFormat { get; set; } = string.Empty;

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("reduce_type")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int ReduceType { get; set; }

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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("freight_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int FreightId { get; set; }

        /// <summary>
        /// 获取或设置重量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("weight")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int Weight { get; set; }

        /// <summary>
        /// 获取或设置重量单位类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("weight_unit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("weight_unit")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int WeightUnit { get; set; }

        /// <summary>
        /// 获取或设置承诺发货时间（单位：天）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_delay_day")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_delay_day")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int DeliveryDelayDay { get; set; }

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
        public int Supply7DayReturnType { get; set; }

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
