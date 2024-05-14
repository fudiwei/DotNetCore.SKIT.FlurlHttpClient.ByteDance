namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /return_refund/{version}/returns/{return_id}/records 接口的响应。</para>
    /// </summary>
    public class ReturnRefundGetReturnRecordsResponse : TikTokShopResponse<ReturnRefundGetReturnRecordsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Record
                    {
                        public static class Types
                        {
                            public class Image : ReturnRefundSearchReturnsResponse.Types.Data.Types.Return.Types.ReturnLineItem.Types.Image
                            {
                            }

                            public class Video
                            {
                                /// <summary>
                                /// 获取或设置视频 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("url")]
                                [System.Text.Json.Serialization.JsonPropertyName("url")]
                                public string Url { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置封面图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cover")]
                                [System.Text.Json.Serialization.JsonPropertyName("cover")]
                                public string CoverUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置视频宽度（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("width")]
                                [System.Text.Json.Serialization.JsonPropertyName("width")]
                                public int Width { get; set; }

                                /// <summary>
                                /// 获取或设置视频高度（单位：像素）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("height")]
                                [System.Text.Json.Serialization.JsonPropertyName("height")]
                                public int Height { get; set; }

                                /// <summary>
                                /// 获取或设置视频时长（单位：毫秒）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("duration_millis")]
                                [System.Text.Json.Serialization.JsonPropertyName("duration_millis")]
                                public int Duration { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置记录类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event")]
                        [System.Text.Json.Serialization.JsonPropertyName("event")]
                        public string Event { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置发起角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("role")]
                        [System.Text.Json.Serialization.JsonPropertyName("role")]
                        public string Role { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("description")]
                        [System.Text.Json.Serialization.JsonPropertyName("description")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置原因文本。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason_text")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason_text")]
                        public string ReasonText { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("note")]
                        [System.Text.Json.Serialization.JsonPropertyName("note")]
                        public string? Notes { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置图片列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("images")]
                        [System.Text.Json.Serialization.JsonPropertyName("images")]
                        public Types.Image[]? ImageList { get; set; }

                        /// <summary>
                        /// 获取或设置视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("videos")]
                        [System.Text.Json.Serialization.JsonPropertyName("videos")]
                        public Types.Video[]? VideoList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置记录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("records")]
                [System.Text.Json.Serialization.JsonPropertyName("records")]
                public Types.Record[] RecordList { get; set; } = default!;
            }
        }
    }
}
