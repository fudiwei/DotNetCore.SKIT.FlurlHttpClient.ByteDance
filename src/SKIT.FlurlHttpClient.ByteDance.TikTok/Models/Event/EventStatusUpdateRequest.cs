using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTok.Models
{
    /// <summary>
    /// <para>表示 [POST] /event/status/update 接口的请求。</para>
    /// </summary>
    public class EventStatusUpdateRequest : TikTokRequest
    {
        public static class Types
        {
            public class Item
            {
                /// <summary>
                /// 获取或设置事件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                public string Event { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置事件订阅状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置事件订阅状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public IList<Types.Item> List { get; set; } = new List<Types.Item>();
    }
}
