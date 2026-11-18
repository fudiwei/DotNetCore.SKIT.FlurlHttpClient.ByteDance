namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /customer_service/{version}/conversations/{conversation_id}/messages 接口的响应。</para>
    /// </summary>
    public class CustomerServiceCreateConversationMessageResponse : TikTokShopResponse<CustomerServiceCreateConversationMessageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message_id")]
                [System.Text.Json.Serialization.JsonPropertyName("message_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string MessageId { get; set; } = default!;
            }
        }
    }
}
