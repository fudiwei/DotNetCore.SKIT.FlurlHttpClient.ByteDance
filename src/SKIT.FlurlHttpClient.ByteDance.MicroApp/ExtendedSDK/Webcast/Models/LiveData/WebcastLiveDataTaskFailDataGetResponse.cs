namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [GET] /live_data/task/fail_data/get 接口的响应。</para>
    /// </summary>
    public class WebcastLiveDataTaskFailDataGetResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailedData
                    {
                        /// <summary>
                        /// 获取或设置直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("roomid")]
                        [System.Text.Json.Serialization.JsonPropertyName("roomid")]
                        public string RoomId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置直播间消息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("msg_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("msg_type")]
                        public string MessageType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置数据 JSON 字符串。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payload")]
                        [System.Text.Json.Serialization.JsonPropertyName("payload")]
                        public string PayloadJson { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置失败数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_list")]
                [System.Text.Json.Serialization.JsonPropertyName("data_list")]
                public Types.FailedData[] FailedDataList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页页数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_num")]
                [System.Text.Json.Serialization.JsonPropertyName("page_num")]
                public int PageNumber { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置请求日志 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logid")]
        [System.Text.Json.Serialization.JsonPropertyName("logid")]
        public string? LogId { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
