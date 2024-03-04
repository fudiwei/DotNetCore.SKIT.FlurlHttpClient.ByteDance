namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/commercial_content/query/ 接口的响应。</para>
    /// </summary>
    public class ResearchAdlibCommercialContentQueryResponse : TikTokV2Response<ResearchAdlibCommercialContentQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class CommercialContent
                    {
                        public static class Types
                        {
                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                public long VideoId { get; set; }

                                /// <summary>
                                /// 获取或设置视频状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public string Status { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置封面图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cover_image_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
                                public string CoverImageUrl { get; set; } = default!;
                            }

                            public class Creator
                            {
                                /// <summary>
                                /// 获取或设置用户名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("username")]
                                [System.Text.Json.Serialization.JsonPropertyName("username")]
                                public string Username { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置广告 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CommercialContentId { get; set; }

                        /// <summary>
                        /// 获取或设置创作日期字符串（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_date")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_date")]
                        public string CreateDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_timestamp")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_timestamp")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置创作者信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creator")]
                        [System.Text.Json.Serialization.JsonPropertyName("creator")]
                        public Types.Creator Creator { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置内容标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("label")]
                        [System.Text.Json.Serialization.JsonPropertyName("label")]
                        public string Label { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置品牌名称列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_names")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_names")]
                        public string[] BrandNameList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("videos")]
                        [System.Text.Json.Serialization.JsonPropertyName("videos")]
                        public Types.Video[] VideoList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商业化内容列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commercial_contents")]
                [System.Text.Json.Serialization.JsonPropertyName("commercial_contents")]
                public Types.CommercialContent[] CommercialContentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置搜索结果 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("search_id")]
                [System.Text.Json.Serialization.JsonPropertyName("search_id")]
                public string? SearchId { get; set; }
            }
        }
    }
}
