namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [GET] /item/comment/reply/list 接口的请求。</para>
    /// </summary>
    public class ItemCommentReplyListRequest : ItemCommentListRequest
    {
        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CommentId { get; set; } = string.Empty;
    }
}
