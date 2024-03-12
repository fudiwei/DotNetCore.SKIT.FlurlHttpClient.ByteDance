namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/douyin/v1/interactive/intention/log/list/ 接口的响应。</para>
    /// </summary>
    public class DouyinInteractiveIntentionLogListV1Response : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class IntentionLogInfo
                    {
                        /// <summary>
                        /// 获取或设置事件名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event")]
                        [System.Text.Json.Serialization.JsonPropertyName("event")]
                        public string Event { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户唯一标识。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置事件时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("event_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("event_time")]
                        public long EventTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置事件内容 JSON 字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string EventContentJson { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置互动日志列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intention_log_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("intention_log_infos")]
                public Types.IntentionLogInfo[] IntentionLogList { get; set; } = default!;

                /// <summary>
                /// 获取或设置查询会话信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("query_session")]
                [System.Text.Json.Serialization.JsonPropertyName("query_session")]
                public string QuerySession { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }

        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public int ErrorNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("log_id")]
        [System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return GetRawStatus() == 200 && ErrorNumber == 0;
        }
    }
}
