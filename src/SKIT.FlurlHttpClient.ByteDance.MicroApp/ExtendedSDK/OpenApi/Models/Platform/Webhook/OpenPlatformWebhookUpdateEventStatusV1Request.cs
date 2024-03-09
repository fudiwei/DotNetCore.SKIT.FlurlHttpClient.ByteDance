using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /platform/v1/webhook/update_event_status/ 接口的请求。</para>
    /// </summary>
    public class OpenPlatformWebhookUpdateEventStatusV1Request : DouyinMicroAppOpenApiRequest
    {
        public static class Types
        {
            public class EventInfo
            {
                /// <summary>
                /// 获取或设置事件名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                public string Event { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置订阅状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置回调事件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_list")]
        [System.Text.Json.Serialization.JsonPropertyName("event_list")]
        public IList<Types.EventInfo> EventList { get; set; } = new List<Types.EventInfo>();
    }
}
