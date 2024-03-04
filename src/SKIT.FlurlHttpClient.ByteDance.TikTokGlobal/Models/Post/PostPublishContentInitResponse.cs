namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/content/init/ 接口的响应。</para>
    /// </summary>
    public class PostPublishContentInitResponse : TikTokV2Response<PostPublishContentInitResponse.Types.Data>
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
            }
        }
    }
}
