namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Events
{
    /// <summary>
    /// <para>表示 item_comment_reply 事件的数据。</para>
    /// <para>REF: https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/webhooks/event-list </para>
    /// </summary>
    public class ItemCommentReplyEvent : TikTokEvent<ItemCommentReplyEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                /// <summary>
                /// 获取或设置评论 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
                public string CommentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置该条评论发布者 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_user_id")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_user_id")]
                public string CommentUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string CommentContent { get; set; } = default!;

                /// <summary>
                /// 获取或设置点赞数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("digg_count")]
                [System.Text.Json.Serialization.JsonPropertyName("digg_count")]
                public int DiggCount { get; set; }

                /// <summary>
                /// 获取或设置回复数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reply_comment_total")]
                [System.Text.Json.Serialization.JsonPropertyName("reply_comment_total")]
                public int ReplyCount { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }
    }
}
