using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /comment/open/get 接口的响应。</para>
    /// </summary>
    public class CommentOpenGetResponse : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Comment
                    {
                        public static class Types
                        {
                            public class User
                            {
                                /// <summary>
                                /// 获取或设置是否匿名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_anonymous")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_anonymous")]
                                public bool IsAnonymous { get; set; }

                                /// <summary>
                                /// 获取或设置脱敏用户名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("scree_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("scree_name")]
                                public string? SecretName { get; set; }

                                /// <summary>
                                /// 获取或设置用户头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("avatar_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
                                public string? AvatarUrl { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置评论 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CommentId { get; set; }

                        /// <summary>
                        /// 获取或设置团购 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("group_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? GroupId { get; set; }

                        /// <summary>
                        /// 获取或设置用户信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user")]
                        [System.Text.Json.Serialization.JsonPropertyName("user")]
                        public Types.User User { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置评论内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("text")]
                        [System.Text.Json.Serialization.JsonPropertyName("text")]
                        public string Text { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置评论图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("imge_urls")]
                        [System.Text.Json.Serialization.JsonPropertyName("imge_urls")]
                        public string[]? ImageUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Internal.CstDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Internal.CstDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }

                        /// <summary>
                        /// 获取或设置评价的 JSON 格式数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratings")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratings")]
                        public string? RatingJson { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置评论列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("comment_list")]
                [System.Text.Json.Serialization.JsonPropertyName("comment_list")]
                public Types.Comment[] CommentList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int TotalCount { get; set; }
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
