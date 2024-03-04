namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/video/init/ 接口的请求。</para>
    /// </summary>
    public class PostPublishVideoInitRequest : TikTokV2Request
    {
        public static class Types
        {
            public class PostInfo
            {
                /// <summary>
                /// 获取或设置隐私级别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privacy_level")]
                [System.Text.Json.Serialization.JsonPropertyName("privacy_level")]
                public string? PrivacyLevel { get; set; }

                /// <summary>
                /// 获取或设置视频标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置是否禁止二重奏。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_duet")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_duet")]
                public bool? DisableDuet { get; set; }

                /// <summary>
                /// 获取或设置是否禁止拼接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_stitch")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_stitch")]
                public bool? DisableStitch { get; set; }

                /// <summary>
                /// 获取或设置是否禁止评论。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("disable_comment")]
                [System.Text.Json.Serialization.JsonPropertyName("disable_comment")]
                public bool? DisableComment { get; set; }

                /// <summary>
                /// 获取或设置使用视频第几毫秒作为封面。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_cover_timestamp_ms")]
                [System.Text.Json.Serialization.JsonPropertyName("video_cover_timestamp_ms")]
                public int? VideoCoverTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置是否是第三方品牌推广内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_content_toggle")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_content_toggle")]
                public bool? IsBrandContent { get; set; }

                /// <summary>
                /// 获取或设置是否是自有品牌推广内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_organic_toggle")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_organic_toggle")]
                public bool? IsBrandOrganic { get; set; }
            }

            public class SourceInfo
            {
                /// <summary>
                /// 获取或设置视频来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string Source { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_url")]
                [System.Text.Json.Serialization.JsonPropertyName("video_url")]
                public string? VideoUrl { get; set; }

                /// <summary>
                /// 获取或设置视频大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_size")]
                [System.Text.Json.Serialization.JsonPropertyName("video_size")]
                public long? VideoSize { get; set; }

                /// <summary>
                /// 获取或设置分片大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chunk_size")]
                [System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
                public long? ChunkSize { get; set; }

                /// <summary>
                /// 获取或设置分片数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_chunk_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_chunk_count")]
                public int? TotalChunkCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置上传信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_info")]
        [System.Text.Json.Serialization.JsonPropertyName("post_info")]
        public Types.PostInfo PostInfo { get; set; } = new Types.PostInfo();

        /// <summary>
        /// 获取或设置源文件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_info")]
        [System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public Types.SourceInfo SourceInfo { get; set; } = new Types.SourceInfo();
    }
}
