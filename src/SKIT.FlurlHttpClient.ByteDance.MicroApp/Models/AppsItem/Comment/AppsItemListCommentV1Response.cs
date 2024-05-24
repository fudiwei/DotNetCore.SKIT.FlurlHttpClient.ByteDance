namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/apps/v1/item/list_comment/ 接口的响应。</para>
    /// </summary>
    public class AppsItemListCommentV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
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
                        /// 获取或设置用户 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_user_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_user_id")]
                        public string UserId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                        public string AvatarUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置点赞数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("digg_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("digg_count")]
                        public int DiggCount { get; set; }

                        /// <summary>
                        /// 获取或设置回复数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_comment_total")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_comment_total")]
                        public int ReplyCount { get; set; }

                        /// <summary>
                        /// 获取或设置是否置顶。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("top")]
                        [System.Text.Json.Serialization.JsonPropertyName("top")]
                        public bool IsTop { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Comment[] CommentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置下一页分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("cursor")]
                public long? NextCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
