namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /post/publish/status/fetch/ 接口的请求。</para>
    /// </summary>
    public class PostPublishStatusFetchRequest : TikTokV2Request
    {
        /// <summary>
        /// 获取或设置发布 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_id")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_id")]
        public string PublishId { get; set; } = string.Empty;
    }
}
