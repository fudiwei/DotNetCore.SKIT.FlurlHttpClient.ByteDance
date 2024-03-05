using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /query 接口的响应。</para>
    /// </summary>
    public class ProductApiQueryResponse : DouyinMicroAppProductApiResponse
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
                            public class ProductInfo
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
                                                public string Unit { get; set; } = default!;

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
                                            }

                                            public class PathInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置跳转的页面。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("path")]
                                                [System.Text.Json.Serialization.JsonPropertyName("path")]
                                                public string PagePath { get; set; } = default!;

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
                                                        public string Name { get; set; } = default!;

                                                        /// <summary>
                                                        /// 获取或设置文字内容。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("text")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                        public string? Text { get; set; }

                                                        /// <summary>
                                                        /// 获取或设置履约文件资源 URL。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("fulfillment_url")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("fulfillment_url")]
                                                        public string? FulfillmentUrl { get; set; }
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
                                                        /// 获取或设置富文本资源 URL。
                                                        /// </summary>
                                                        [Newtonsoft.Json.JsonProperty("url")]
                                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                                        public string? Url { get; set; }
                                                    }
                                                }

                                                /// <summary>
                                                /// 获取或设置文字。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                                public string? Text { get; set; }

                                                /// <summary>
                                                /// 获取或设置图片资源 URL。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("img_url")]
                                                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                                                public string? ImageUrl { get; set; }

                                                /// <summary>
                                                /// 获取或设置富文本内容列表。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("rich_text")]
                                                [System.Text.Json.Serialization.JsonPropertyName("rich_text")]
                                                public Types.RichText[]? RichTextList { get; set; }
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
                                        /// 获取或设置小程序 AppId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("appid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                        public string AppId { get; set; } = default!;

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
                                        public string Title { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置商品资质资源 URL 列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("qualification_urls")]
                                        [System.Text.Json.Serialization.JsonPropertyName("qualification_urls")]
                                        public string[] QualificationUrlList { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置购物须知。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("purchase_precaution")]
                                        [System.Text.Json.Serialization.JsonPropertyName("purchase_precaution")]
                                        public string PurchasePrecaution { get; set; } = default!;

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
                                        public Types.PathInfo[]? PathInfoList { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品履约列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_fulfillment_lst")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_fulfillment_lst")]
                                        public Types.ProductFulfilment[]? ProductFulfillmentList { get; set; }

                                        /// <summary>
                                        /// 获取或设置商品详情列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("product_detail_lst")]
                                        [System.Text.Json.Serialization.JsonPropertyName("product_detail_lst")]
                                        public Types.ProductDetail[]? ProductDetailLst { get; set; } = default!;

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

                                    public class ProductStatusInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置商品状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                                        public int Status { get; set; }

                                        /// <summary>
                                        /// 获取或设置下架或审核不通过原因。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                        public string? RejectReason { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                                public int ProductType { get; set; }

                                /// <summary>
                                /// 获取或设置商品通用参数信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("common_product_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("common_product_info")]
                                public Types.CommonProductInfo CommonProductInfo { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置课程参数信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("course_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("course_info")]
                                public Types.CourseInfo? CourseInfo { get; set; }

                                /// <summary>
                                /// 获取或设置商品状态信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_status")]
                                public Types.ProductStatusInfo? ProductStatusInfo { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置已上架的商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_on_shelf")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_on_shelf")]
                        public Types.ProductInfo? ProductOnShelf { get; set; }

                        /// <summary>
                        /// 获取或设置审核中的商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_reviewing")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_reviewing")]
                        public Types.ProductInfo? ProductReviewing { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[] ProductList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
