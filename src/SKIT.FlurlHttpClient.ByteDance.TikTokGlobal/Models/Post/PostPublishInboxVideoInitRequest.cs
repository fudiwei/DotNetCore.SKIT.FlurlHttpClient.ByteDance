namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/inbox/video/init/ 接口的请求。</para>
    /// </summary>
    public class PostPublishInboxVideoInitRequest : TikTokV2Request
    {
        public static class Types
        {
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
        /// 获取或设置源文件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source_info")]
        [System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public Types.SourceInfo SourceInfo { get; set; } = new Types.SourceInfo();
    }
}
