namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/ad/reject_reason 接口的响应。</para>
    /// </summary>
    public class AdvertisingRejectReasonResponse : OceanEngineResponse<AdvertisingRejectReasonResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Item
                    {
                        public static class Types
                        {
                            public class AdRejection
                            {
                                /// <summary>
                                /// 获取或设置广告计划 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("ad_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                                public long AdvertisingId { get; set; }

                                /// <summary>
                                /// 获取或设置审核建议数据列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_data")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_data")]
                                public Types.RejectionItem[]? RejectionList { get; set; }
                            }

                            public class CreativeRejection
                            {
                                /// <summary>
                                /// 获取或设置创意 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("creative_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("creative_id")]
                                public long CreativeId { get; set; }

                                /// <summary>
                                /// 获取或设置审核建议数据列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_data")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_data")]
                                public Types.RejectionItem[]? RejectionList { get; set; }

                                /// <summary>
                                /// 获取或设置程序化创意的素材维度审核建议列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("material_reject")]
                                [System.Text.Json.Serialization.JsonPropertyName("material_reject")]
                                public Types.MaterialRejection[]? MaterialRejectionList { get; set; }
                            }

                            public class MaterialRejection
                            {
                                /// <summary>
                                /// 获取或设置标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置图片 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("image_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                                public string? ImageId { get; set; }

                                /// <summary>
                                /// 获取或设置视频 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("video_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                                public string? VideoId { get; set; }

                                /// <summary>
                                /// 获取或设置审核建议。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string RejectReason { get; set; } = default!;
                            }

                            public class RejectionItem
                            {
                                /// <summary>
                                /// 获取或设置审核项。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_item")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_item")]
                                public string Item { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置审核建议。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("reject_reason")]
                                [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                                public string Reason { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置计划维度审核建议。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_reject")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_reject")]
                        public Types.AdRejection? AdRejection { get; set; }

                        /// <summary>
                        /// 获取或设置创意维度审核建议列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_reject")]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_reject")]
                        public Types.CreativeRejection[]? CreativeRejectionList { get; set; }

                        /// <summary>
                        /// 获取或设置程序化创意的素材维度审核建议列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_reject")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_reject")]
                        public Types.MaterialRejection[]? MaterialRejectionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置审核建议列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public static Types.Item[] List { get; set; } = default!;
            }
        }
    }
}
