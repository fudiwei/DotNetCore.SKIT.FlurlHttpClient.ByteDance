namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/sizecharts/search 接口的响应。</para>
    /// </summary>
    public class ProductSearchSizeChartsResponse : TikTokShopResponse<ProductSearchSizeChartsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SizeChart
                    {
                        public static class Types
                        {
                            public class Image
                            {
                                /// <summary>
                                /// 获取或设置本地化语种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("locale")]
                                [System.Text.Json.Serialization.JsonPropertyName("locale")]
                                public string Locale { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图片 URI。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("uri")]
                                [System.Text.Json.Serialization.JsonPropertyName("uri")]
                                public string Uri { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string TemplateId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模板名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("images")]
                        [System.Text.Json.Serialization.JsonPropertyName("images")]
                        public Types.Image[] ImageList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置尺码表模板列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size_chart")]
                [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
                public Types.SizeChart[] SizeChartList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
