namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /customer_service/{version}/agents/settings 接口的请求。</para>
    /// </summary>
    public class CustomerServiceUpdateAgentSettingsRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置是否可接收会话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_accept_chat")]
        [System.Text.Json.Serialization.JsonPropertyName("can_accept_chat")]
        public bool CanAcceptChat { get; set; }
    }
}
