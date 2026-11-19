namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobal.Models
{
    /// <summary>
    /// <para>表示 [POST] /minis/subscription/reactivate/ 接口的请求。</para>
    /// </summary>
    public class MinisSubscriptionReactivateRequest : TikTokV2Request
    {
        public static class Types
        {
            public class OrderInfo : MinisSubscriptionCreateRequest.Types.OrderInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置订阅 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscription_id")]
        [System.Text.Json.Serialization.JsonPropertyName("subscription_id")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        public Types.OrderInfo? OrderInfo { get; set; }
    }
}
