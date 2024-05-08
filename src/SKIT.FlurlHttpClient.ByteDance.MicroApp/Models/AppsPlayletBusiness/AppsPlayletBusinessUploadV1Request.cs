namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/v1/playlet_business/upload/ 接口的请求。</para>
    /// </summary>
    public class AppsPlayletBusinessUploadV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class Context
            {
                public static class Types
                {
                    public class Device
                    {
                        /// <summary>
                        /// 获取或设置用户的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string? OpenId { get; set; }
                    }

                    public class Ad
                    {
                        /// <summary>
                        /// 获取或设置广告回调参数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("callback")]
                        [System.Text.Json.Serialization.JsonPropertyName("callback")]
                        public string? Callback { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置设备信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device")]
                [System.Text.Json.Serialization.JsonPropertyName("device")]
                public Types.Device? Device { get; set; }

                /// <summary>
                /// 获取或设置广告信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad")]
                [System.Text.Json.Serialization.JsonPropertyName("ad")]
                public Types.Ad? Ad { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置上下文信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("context")]
        [System.Text.Json.Serialization.JsonPropertyName("context")]
        public Types.Context Context { get; set; } = new Types.Context();

        /// <summary>
        /// 获取或设置事件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("event_type")]
        [System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置事件参数 JSON 字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties")]
        [System.Text.Json.Serialization.JsonPropertyName("properties")]
        public string? PropertiesJson { get; set; }

        /// <summary>
        /// 获取或设置事件发生时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }
    }
}
