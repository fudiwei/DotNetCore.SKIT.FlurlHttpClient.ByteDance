namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /customer_service/{version}/conversations/{conversation_id}/messages/read 接口的请求。</para>
    /// </summary>
    public class CustomerServiceReadConversationMessageRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置会话 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ConversationId { get; set; } = string.Empty;
    }
}
