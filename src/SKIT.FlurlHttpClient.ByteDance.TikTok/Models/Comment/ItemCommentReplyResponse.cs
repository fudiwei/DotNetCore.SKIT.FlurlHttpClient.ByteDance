namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /item/comment/reply 接口的响应。</para>
    /// </summary>
    public class ItemCommentReplyResponse : TikTokResponse<ItemCommentReplyResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : TikTokResposneData
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
