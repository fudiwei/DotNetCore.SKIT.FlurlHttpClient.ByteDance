namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /customer_service/{version}/conversations 接口的响应。</para>
    /// </summary>
    public class CustomerServiceCreateConversationResponse : TikTokShopResponse<CustomerServiceCreateConversationResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置会话 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("conversation_id")]
                [System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string ConversationId { get; set; } = default!;
            }
        }
    }
}
