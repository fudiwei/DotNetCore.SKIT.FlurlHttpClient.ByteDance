namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Events
{
    /// <summary>
    /// <para>表示 im_receive_msg 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/interaction-management/private-message/private-msg-webhook ]]> <br/>
    /// <![CDATA[ https://developer.open-douyin.com/docs/resource/zh-CN/mini-app/develop/server/instant-message/private-message/private-msg-webhook ]]>
    /// </para>
    /// </summary>
    public class IMReceiveMessageEvent : DouyinOpenEvent<IMReceiveMessageEvent.Types.Content>
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class UserInfo : IMEnterDirectMessageEvent.Types.Content.Types.UserInfo
                    {
                    }

                    public class CardData
                    {
                        /// <summary>
                        /// 获取或设置表单项标签。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("label")]
                        [System.Text.Json.Serialization.JsonPropertyName("label")]
                        public string Label { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置表单项内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public string Value { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_message_id")]
                [System.Text.Json.Serialization.JsonPropertyName("server_message_id")]
                public string ServerMessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会话 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conversation_short_id")]
                [System.Text.Json.Serialization.JsonPropertyName("conversation_short_id")]
                public string ConversationShortId { get; set; } = default!;

                /// <summary>
                /// 获取或设置会话类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conversation_type")]
                [System.Text.Json.Serialization.JsonPropertyName("conversation_type")]
                public int ConversationType { get; set; }

                /// <summary>
                /// 获取或设置场景类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_type")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
                public int SceneType { get; set; }

                /// <summary>
                /// 获取或设置消息类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message_type")]
                [System.Text.Json.Serialization.JsonPropertyName("message_type")]
                public string MessageType { get; set; } = default!;

                /// <summary>
                /// 获取或设置消息来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string? Source { get; set; }

                /// <summary>
                /// 获取或设置文字内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// 获取或设置资源类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_type")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_type")]
                public string? ResourceType { get; set; }

                /// <summary>
                /// 获取或设置资源链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_url")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_url")]
                public string? ResourceUrl { get; set; }

                /// <summary>
                /// 获取或设置资源高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_height")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_height")]
                public int? ResourceHeight { get; set; }

                /// <summary>
                /// 获取或设置资源宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("resource_width")]
                [System.Text.Json.Serialization.JsonPropertyName("resource_width")]
                public int? ResourceWidth { get; set; }

                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_id")]
                public string? ItemId { get; set; }

                /// <summary>
                /// 获取或设置卡片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string? CardId { get; set; }

                /// <summary>
                /// 获取或设置卡片状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_status")]
                [System.Text.Json.Serialization.JsonPropertyName("card_status")]
                public int? CardStatus { get; set; }

                /// <summary>
                /// 获取或设置卡片数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_data")]
                [System.Text.Json.Serialization.JsonPropertyName("card_data")]
                public Types.CardData[]? CardData { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置用户列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("user_infos")]
                public Types.UserInfo[]? UserList { get; set; }
            }
        }
    }
}
