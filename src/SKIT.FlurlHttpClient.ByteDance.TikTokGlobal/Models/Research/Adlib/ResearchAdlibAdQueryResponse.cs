namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /research/adlib/ad/query/ 接口的响应。</para>
    /// </summary>
    public class ResearchAdlibAdQueryResponse : TikTokV2Response<ResearchAdlibAdQueryResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Ad
                    {
                        public static class Types
                        {
                            public class Advertisement
                            {
                                public static class Types
                                {
                                    public class Video
                                    {
                                        /// <summary>
                                        /// 获取或设置视频 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                                        public string Url { get; set; } = default!;
                                    }

                                    public class Reach
                                    {
                                        /// <summary>
                                        /// 获取或设置 UV。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("unique_users_seen")]
                                        [System.Text.Json.Serialization.JsonPropertyName("unique_users_seen")]
                                        public string UniqueUsersSeen { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置广告 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long AdId { get; set; }

                                /// <summary>
                                /// 获取或设置首次曝光日期字符串（格式：yyyyMMdd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("first_shown_date")]
                                [System.Text.Json.Serialization.JsonPropertyName("first_shown_date")]
                                public string FirstShownDateString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置末次曝光日期字符串（格式：yyyyMMdd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("last_shown_date")]
                                [System.Text.Json.Serialization.JsonPropertyName("last_shown_date")]
                                public string LastShownDateString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public string Status { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("videos")]
                                [System.Text.Json.Serialization.JsonPropertyName("videos")]
                                public Types.Video[] VideoList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图片列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_urls")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_urls")]
                                public string[] ImageList { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置触客信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reach")]
                                [System.Text.Json.Serialization.JsonPropertyName("reach")]
                                public Types.Reach Reach { get; set; } = default!;
                            }

                            public class Advertiser
                            {
                                /// <summary>
                                /// 获取或设置广告主 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("business_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("business_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long BusinessId { get; set; }

                                /// <summary>
                                /// 获取或设置广告主名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("business_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("business_name")]
                                public string BusinessName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置资金来源。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("paid_by")]
                                [System.Text.Json.Serialization.JsonPropertyName("paid_by")]
                                public string PaidBy { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置广告信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad")]
                        public Types.Advertisement Advertisement { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置广告主信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser")]
                        public Types.Advertiser Advertiser { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置广告列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ads")]
                [System.Text.Json.Serialization.JsonPropertyName("ads")]
                public Types.Ad[] AdList { get; set; } = default!;

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
