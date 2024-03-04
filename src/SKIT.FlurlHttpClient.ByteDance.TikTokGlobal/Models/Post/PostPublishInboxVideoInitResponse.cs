namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/inbox/video/init/ 接口的响应。</para>
    /// </summary>
    public class PostPublishInboxVideoInitResponse : TikTokV2Response<PostPublishInboxVideoInitResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置发布 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_id")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_id")]
                public string PublishId { get; set; } = default!;

                /// <summary>
                /// 获取或设置上传地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_url")]
                [System.Text.Json.Serialization.JsonPropertyName("upload_url")]
                public string? UploadUrl { get; set; }
            }
        }
    }
}
