namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /event/{version}/webhooks 接口的响应。</para>
    /// </summary>
    public class EventGetWebhooksResponse : TikTokShopResponse<EventGetWebhooksResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Webhook
                    {
                        /// <summary>
                        /// 获取或设置事件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
                        public string EventType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回调地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string WebhookUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置创建时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 Webhook 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("webhooks")]
                [System.Text.Json.Serialization.JsonPropertyName("webhooks")]
                public Types.Webhook[] WebhookList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }
    }
}
