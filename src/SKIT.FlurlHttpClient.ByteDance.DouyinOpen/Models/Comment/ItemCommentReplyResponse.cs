namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /item/comment/reply 接口的响应。</para>
    /// </summary>
    public class ItemCommentReplyResponse : DouyinOpenResponse<ItemCommentReplyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                /// <summary>
                /// 获取或设置评论 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
                public string CommentId { get; set; } = default!;
            }
        }
    }
}
