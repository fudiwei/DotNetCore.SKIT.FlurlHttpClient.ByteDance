namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /customer_service/{version}/agents/settings 接口的响应。</para>
    /// </summary>
    public class CustomerServiceGetAgentSettingsResponse : TikTokShopResponse<CustomerServiceGetAgentSettingsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否可接收会话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("can_accept_chat")]
                [System.Text.Json.Serialization.JsonPropertyName("can_accept_chat")]
                public bool CanAcceptChat { get; set; }
            }
        }
    }
}
