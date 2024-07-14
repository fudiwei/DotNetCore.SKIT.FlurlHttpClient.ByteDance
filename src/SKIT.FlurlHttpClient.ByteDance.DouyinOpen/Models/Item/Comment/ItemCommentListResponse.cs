namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /item/comment/list/ 接口的响应。</para>
    /// </summary>
    public class ItemCommentListResponse : DouyinOpenResponse<ItemCommentListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Comment
                    {
                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_id")]
                        public string CommentId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回复的评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_comment_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_comment_id")]
                        public string? ReplyCommentId { get; set; }

                        /// <summary>
                        /// 获取或设置该条评论发布者 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_user_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_user_id")]
                        public string CommentUserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置该条评论发布者的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string? CommentUserNickname { get; set; }

                        /// <summary>
                        /// 获取或设置该条评论发布者的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                        public string? CommentUserAvatarUrl { get; set; }

                        /// <summary>
                        /// 获取或设置回复内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

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
                        /// 获取或设置是否被置顶。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("top")]
                        [System.Text.Json.Serialization.JsonPropertyName("top")]
                        public bool IsTop { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Comment[] CommentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
