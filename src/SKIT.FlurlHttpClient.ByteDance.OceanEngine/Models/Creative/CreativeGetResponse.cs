using System;

namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/creative/get 接口的响应。</para>
    /// </summary>
    public class CreativeGetResponse : OceanEngineResponse<CreativeGetResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Creative
                    {
                        public static class Types
                        {
                            public class Material
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
                            }
                        }

                        /// <summary>
                        /// 获取或设置创意 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_id")]
                        public long? CreativeId { get; set; }

                        /// <summary>
                        /// 获取或设置广告主 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("advertiser_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("advertiser_id")]
                        public long? AdvertiserId { get; set; }

                        /// <summary>
                        /// 获取或设置广告计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ad_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                        public long? AdvertisingId { get; set; }

                        /// <summary>
                        /// 获取或设置创意标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? CreativeTitle { get; set; }

                        /// <summary>
                        /// 获取或设置创意状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string? Status { get; set; }

                        /// <summary>
                        /// 获取或设置操作状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("opt_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("opt_status")]
                        public string? Operation { get; set; }

                        /// <summary>
                        /// 获取或设置动态词包 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_word_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_word_ids")]
                        public long[]? CreativeWordIdList { get; set; }

                        /// <summary>
                        /// 获取或设置创意素材类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_mode")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_mode")]
                        public string? ImageMode { get; set; }

                        /// <summary>
                        /// 获取或设置创意素材图片 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_ids")]
                        public string[]? ImageIdList { get; set; }

                        /// <summary>
                        /// 获取或设置创意素材封面图片 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                        public string? ImageId { get; set; }

                        /// <summary>
                        /// 获取或设置创意素材视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        public string? VideoId { get; set; }

                        /// <summary>
                        /// 获取或设置第三方 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_party_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_party_id")]
                        public string? ThirdPartyId { get; set; }

                        /// <summary>
                        /// 获取或设置素材列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("metarials")]
                        [System.Text.Json.Serialization.JsonPropertyName("metarials")]
                        public Types.Material[]? MaterialList { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset? CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置修改时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("creative_modify_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("creative_modify_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                        public DateTimeOffset? UpdateTime { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置广告组列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Creative[] CampaignList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
