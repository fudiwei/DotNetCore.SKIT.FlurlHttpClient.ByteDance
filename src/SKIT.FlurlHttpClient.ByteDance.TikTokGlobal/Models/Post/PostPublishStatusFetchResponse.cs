namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/status/fetch/ 接口的响应。</para>
    /// </summary>
    public class PostPublishStatusFetchResponse : TikTokV2Response<PostPublishStatusFetchResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置发布状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置帖子 ID 列表
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publicaly_available_post_id")]
                [System.Text.Json.Serialization.JsonPropertyName("publicaly_available_post_id")]
                public long[]? PublicalyAvailablePostId { get; set; }

                /// <summary>
                /// 获取或设置已上传的字节大小。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uploaded_bytes")]
                [System.Text.Json.Serialization.JsonPropertyName("uploaded_bytes")]
                public long? UploadedByteSize { get; set; }

                /// <summary>
                /// 获取或设置已下载的字节大小。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("downloaded_bytes")]
                [System.Text.Json.Serialization.JsonPropertyName("downloaded_bytes")]
                public long? DownloadedByteSize { get; set; }
            }
        }
    }
}
