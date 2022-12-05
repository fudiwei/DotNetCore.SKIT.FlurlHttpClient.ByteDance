namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /event/status/list 接口的响应。</para>
    /// </summary>
    public class EventStatusListResponse : DouyinOpenResponse<EventStatusListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
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
                        public string Event { get; set; } = default!;

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
                public Types.Item[] List { get; set; } = default!;
            }
        }
    }
}
