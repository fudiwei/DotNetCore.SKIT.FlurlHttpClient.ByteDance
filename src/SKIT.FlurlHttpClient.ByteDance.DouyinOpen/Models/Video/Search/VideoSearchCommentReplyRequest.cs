namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /video/search/comment/reply 接口的请求。</para>
    /// </summary>
    public class VideoSearchCommentReplyRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置特殊加密的视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sec_item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sec_item_id")]
        public string SecurityItemId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
        public string? CommentId { get; set; }

        /// <summary>
        /// 获取或设置评论内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
