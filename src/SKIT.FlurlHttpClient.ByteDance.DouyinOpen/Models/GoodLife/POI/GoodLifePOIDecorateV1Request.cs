using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/poi/poi/decorate 接口的请求。</para>
    /// </summary>
    public class GoodLifePOIDecorateV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class POI
            {
                public static class Types
                {
                    public class Decoration
                    {
                        public static class Types
                        {
                            public class Image
                            {
                                /// <summary>
                                /// 获取或设置图片链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置图片排序。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sort_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("sort_value")]
                                public int? SortValue { get; set; }
                            }

                            public class RecommendList
                            {
                                /// <summary>
                                /// 获取或设置相册名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Title { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置相册图片列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("items")]
                                [System.Text.Json.Serialization.JsonPropertyName("items")]
                                public RecommendItem? Items { get; set; }
                            }

                            public class RecommendItem
                            {
                                /// <summary>
                                /// 获取或设置图片链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                public string Url { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置图片名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_name")]
                                public string Name { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置图片排序。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sort_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("sort_value")]
                                public int? SortValue { get; set; }
                            }

                            public class Announcement
                            {
                                /// <summary>
                                /// 获取或设置图片链接。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_url")]
                                public string Url { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string Name { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置描述。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("description")]
                                [System.Text.Json.Serialization.JsonPropertyName("description")]
                                public string Description { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置是否展示。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("enable")]
                                [System.Text.Json.Serialization.JsonPropertyName("enable")]
                                public bool IsEnabled { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置服务设施标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tags")]
                        [System.Text.Json.Serialization.JsonPropertyName("tags")]
                        public IList<string>? TagList { get; set; }

                        /// <summary>
                        /// 获取或设置头图列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_images")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_images")]
                        public IList<Types.Image>? HeadImageList { get; set; }

                        /// <summary>
                        /// 获取或设置相册列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("recommends")]
                        [System.Text.Json.Serialization.JsonPropertyName("recommends")]
                        public Types.RecommendList? RecommendList { get; set; }

                        /// <summary>
                        /// 获取或设置外显小图列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover_images")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover_images")]
                        public IList<Types.Image>? CoverImageList { get; set; }

                        /// <summary>
                        /// 获取或设置公告信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("announcement")]
                        [System.Text.Json.Serialization.JsonPropertyName("announcement")]
                        public Types.Announcement? Announcement { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置三方 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_id")]
                public string ThirdId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("poi_id")]
                [System.Text.Json.Serialization.JsonPropertyName("poi_id")]
                public string POIId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置装修信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license")]
                [System.Text.Json.Serialization.JsonPropertyName("license")]
                public Types.Decoration Decoration { get; set; } = new Types.Decoration();
            }
        }

        /// <summary>
        /// 获取或设置门店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datas")]
        [System.Text.Json.Serialization.JsonPropertyName("datas")]
        public IList<Types.POI> POIList { get; set; } = new List<Types.POI>();
    }
}
