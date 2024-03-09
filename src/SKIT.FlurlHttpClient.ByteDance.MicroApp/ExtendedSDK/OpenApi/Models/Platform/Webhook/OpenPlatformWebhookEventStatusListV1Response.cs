namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [GET] /platform/v1/webhook/event_status_list/ 接口的响应。</para>
    /// </summary>
    public class OpenPlatformWebhookEventStatusListV1Response : DouyinMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class WebhookInfo
                    {
                        /// <summary>
                        /// 获取或设置 Webhook Secret。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("secret")]
                        [System.Text.Json.Serialization.JsonPropertyName("secret")]
                        public string Secret { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置回调地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("callback_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
                        public string CallbackUrl { get; set; } = default!;
                    }

                    public class EventInfo
                    {
                        /// <summary>
                        /// 获取或设置事件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event")]
                        [System.Text.Json.Serialization.JsonPropertyName("event")]
                        public string Event { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置中文名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name_cn")]
                        [System.Text.Json.Serialization.JsonPropertyName("name_cn")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置事件描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc")]
                        public string Description { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订阅状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 Webhook 配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("webhook_info")]
                [System.Text.Json.Serialization.JsonPropertyName("webhook_info")]
                public Types.WebhookInfo WebhookInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置回调事件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event_list")]
                [System.Text.Json.Serialization.JsonPropertyName("event_list")]
                public Types.EventInfo[] EventList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
