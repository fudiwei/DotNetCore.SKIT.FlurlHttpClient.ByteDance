namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /customer_service/{version}/conversations 接口的请求。</para>
    /// </summary>
    public class CustomerServiceCreateConversationRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置买家用户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; } = string.Empty;
    }
}
