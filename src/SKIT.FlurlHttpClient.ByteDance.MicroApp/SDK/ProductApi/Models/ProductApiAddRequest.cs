using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /add 接口的请求。</para>
    /// </summary>
    public class ProductApiAddRequest : ByteDanceMicroAppProductApiRequest
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class CommonProductInfo
                    {
                        public static class Types
                        {
                            public class PriceInfo
                            {
                                /// <summary>
                                /// 获取或设置价格粒度单位。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unit")]
                                [System.Text.Json.Serialization.JsonPropertyName("unit")]
                                public string Unit { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("price")]
                                [System.Text.Json.Serialization.JsonPropertyName("price")]
                                public int Price { get; set; }

                                /// <summary>
                                /// 获取或设置实际成交价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("real_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("real_price")]
                                public int? RealPrice { get; set; }

                                /// <summary>
                                /// 获取或设置当前服务的实际成交价格区间最低价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("range_min_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("range_min_price")]
                                public int? RangeMinPrice { get; set; }

                                /// <summary>
                                /// 获取或设置当前服务的实际成交价格区间最高价格（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("range_max_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("range_max_price")]
                                public int? RangeMaxPrice { get; set; }
                            }

                            public class PathInfo
                            {
                                /// <summary>
                                /// 获取或设置跳转的页面。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("path")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string PagePath { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置页面参数字典。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("query")]
                                [System.Text.Json.Serialization.JsonPropertyName("query")]
                                public IDictionary<string, string>? QueryMap { get; set; }
                            }

                            public class ProductFulfilment
                            {
                                public static class Types
                                {
                                    public class FulfillmentContent
                                    {
                                        /// <summary>
                                        /// 获取或设置履约内容名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                                        public string Name { get; set; } = string.Empty;

                                        /// <summary>
                                        /// 获取或设置文字内容。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public string? Text { get; set; }

                                        /// <summary>
                                        /// 获取或设置履约文件资源路径。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("fulfillment_uri")]
                                        [System.Text.Json.Serialization.JsonPropertyName("fulfillment_uri")]
                                        public string? FulfillmentPath { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置履约详情。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fulfillment_content")]
                                [System.Text.Json.Serialization.JsonPropertyName("fulfillment_content")]
                                public Types.FulfillmentContent FulfillmentContent { get; set; } = new Types.FulfillmentContent();

                                /// <summary>
                                /// 获取或设置履约类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fulfillment_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("fulfillment_type")]
                                public int FulfillmentType { get; set; }
                            }

                            public class ProductDetail
                            {
                                public static class Types
                                {
                                    public class RichText
                                    {
                                        /// <summary>
                                        /// 获取或设置富文本字符串。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("text")]
                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                        public string? String { get; set; }

                                        /// <summary>
                                        /// 获取或设置富文本资源路径。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("uri")]
                                        [System.Text.Json.Serialization.JsonPropertyName("uri")]
                                        public string? FilePath { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置文字。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public string? Text { get; set; }

                                /// <summary>
                                /// 获取或设置图片资源路径。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("img_uri")]
                                [System.Text.Json.Serialization.JsonPropertyName("img_uri")]
                                public string? ImagePath { get; set; }

                                /// <summary>
                                /// 获取或设置富文本内容列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("rich_text")]
                                [System.Text.Json.Serialization.JsonPropertyName("rich_text")]
                                public IList<Types.RichText>? RichTextList { get; set; }
                            }

                            public class AnchorInfo
                            {
                                public static class Types
                                {
                                    public class VideoAnchorInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置锚点文案。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("anchor_title")]
                                        [System.Text.Json.Serialization.JsonPropertyName("anchor_title")]
                                        public string? AnchorTitle { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置视频锚点信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_anchor_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_anchor_info")]
                                public Types.VideoAnchorInfo? VideoAnchorInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置一级商品分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_class")]
                        public int FirstClassId { get; set; }

                        /// <summary>
                        /// 获取或设置二级商品分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_class")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_class")]
                        public int SecondClassId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品资质资源路径列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("qualification_uris")]
                        [System.Text.Json.Serialization.JsonPropertyName("qualification_uris")]
                        public IList<string> QualificationPathList { get; set; } = new List<string>();

                        /// <summary>
                        /// 获取或设置购物须知。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("purchase_precaution")]
                        [System.Text.Json.Serialization.JsonPropertyName("purchase_precaution")]
                        public string PurchasePrecaution { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置行业类目。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("industry_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("industry_type")]
                        public int IndustryType { get; set; }

                        /// <summary>
                        /// 获取或设置价格信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("price_info")]
                        public Types.PriceInfo PriceInfo { get; set; } = new Types.PriceInfo();

                        /// <summary>
                        /// 获取或设置路径信息列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("path_info_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("path_info_lst")]
                        public IList<Types.PathInfo>? PathInfoList { get; set; }

                        /// <summary>
                        /// 获取或设置商品履约列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_fulfillment_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_fulfillment_lst")]
                        public IList<Types.ProductFulfilment>? ProductFulfillmentList { get; set; }

                        /// <summary>
                        /// 获取或设置商品详情列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_detail_lst")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_detail_lst")]
                        public IList<Types.ProductDetail>? ProductDetailLst { get; set; } = new List<Types.ProductDetail>();

                        /// <summary>
                        /// 获取或设置锚点信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("anchor_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("anchor_info")]
                        public Types.AnchorInfo? AnchorInfo { get; set; }
                    }

                    public class CourseInfo
                    {
                        /// <summary>
                        /// 获取或设置老师介绍。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("teacher_introduction")]
                        [System.Text.Json.Serialization.JsonPropertyName("teacher_introduction")]
                        public string? TeacherIntroduction { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品通用参数信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_product_params")]
                [System.Text.Json.Serialization.JsonPropertyName("common_product_params")]
                public Types.CommonProductInfo CommonProductInfo { get; set; } = new Types.CommonProductInfo();

                /// <summary>
                /// 获取或设置课程参数信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("course_params")]
                [System.Text.Json.Serialization.JsonPropertyName("course_params")]
                public Types.CourseInfo? CourseInfo { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public int ProductType { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = new Types.Product();
    }
}
