namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /customer_service/{version}/conversations 接口的响应。</para>
    /// </summary>
    public class CustomerServiceGetConversationsResponse : TikTokShopResponse<CustomerServiceGetConversationsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Conversation
                    {
                        public static class Types
                        {
                            public class Participant
                            {
                                /// <summary>
                                /// 获取或设置用户 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_id")]
                                public string? UserId { get; set; }

                                /// <summary>
                                /// 获取或设置 IM 用户 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("im_user_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("im_user_id")]
                                public string? IMUserId { get; set; }

                                /// <summary>
                                /// 获取或设置头像 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("avatar")]
                                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                                public string AvatarUrl { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置角色。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("role")]
                                [System.Text.Json.Serialization.JsonPropertyName("role")]
                                public string Role { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置昵称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("nickname")]
                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                public string Nickname { get; set; } = default!;
                            }

                            public class Message
                            {
                                /// <summary>
                                /// 获取或设置消息 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string MessageId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置消息类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public string Type { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置消息内容 JSON 字符串。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("content")]
                                [System.Text.Json.Serialization.JsonPropertyName("content")]
                                public string ContentJson { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置发送者信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sender")]
                                [System.Text.Json.Serialization.JsonPropertyName("sender")]
                                public Types.Participant Sender { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置是否可见。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("is_visible")]
                                [System.Text.Json.Serialization.JsonPropertyName("is_visible")]
                                public bool IsVisible { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置会话 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string ConversationId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置参与者数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("participant_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("participant_count")]
                        public int ParticipantCount { get; set; }

                        /// <summary>
                        /// 获取或设置未读消息数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unread_count")]
                        [System.Text.Json.Serialization.JsonPropertyName("unread_count")]
                        public int UnreadMessageCount { get; set; }

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否可发送消息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("can_send_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("can_send_message")]
                        public bool CanSendMessage { get; set; }

                        /// <summary>
                        /// 获取或设置参与者列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("participants")]
                        [System.Text.Json.Serialization.JsonPropertyName("participants")]
                        public Types.Participant[] ParticipantList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置最新消息信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("latest_message")]
                        [System.Text.Json.Serialization.JsonPropertyName("latest_message")]
                        public Types.Message? LatestMessage { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置会话列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conversations")]
                [System.Text.Json.Serialization.JsonPropertyName("conversations")]
                public Types.Conversation[] ConversationList { get; set; } = default!;

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }
            }
        }
    }
}
