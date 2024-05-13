namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /customer_service/{version}/conversations/{conversation_id}/messages 接口的响应。</para>
    /// </summary>
    public class CustomerServiceGetConversationMessagesResponse : TikTokShopResponse<CustomerServiceGetConversationMessagesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Message : CustomerServiceGetConversationsResponse.Types.Data.Types.Conversation.Types.Message
                    {
                    }
                }

                /// <summary>
                /// 获取或设置消息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("messages")]
                [System.Text.Json.Serialization.JsonPropertyName("messages")]
                public Types.Message[] MessageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置下一页分页令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_page_token")]
                [System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
                public string? NextPageToken { get; set; }

                /// <summary>
                /// 获取或设置不支持的消息提示。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unsupported_msg_tips")]
                [System.Text.Json.Serialization.JsonPropertyName("unsupported_msg_tips")]
                public string? UnsupportedMessageTips { get; set; }
            }
        }
    }
}
