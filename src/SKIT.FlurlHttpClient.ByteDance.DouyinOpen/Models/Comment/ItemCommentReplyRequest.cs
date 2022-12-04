namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /item/comment/reply 接口的请求。</para>
    /// </summary>
    public class ItemCommentReplyRequest : DouyinOpenRequest
    {
        /// <summary>
        /// 获取或设置视频 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string ItemId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("comment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
        public string? CommentId { get; set; }

        /// <summary>
        /// 获取或设置回复内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;
    }
}
