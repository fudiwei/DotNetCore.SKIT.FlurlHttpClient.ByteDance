namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /video/comment/reply/list 接口的请求。</para>
    /// </summary>
    public class VideoCommentReplyListRequest : VideoCommentListRequest
    {
        /// <summary>
        /// 获取或设置评论 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CommentId { get; set; } = string.Empty;
    }
}
