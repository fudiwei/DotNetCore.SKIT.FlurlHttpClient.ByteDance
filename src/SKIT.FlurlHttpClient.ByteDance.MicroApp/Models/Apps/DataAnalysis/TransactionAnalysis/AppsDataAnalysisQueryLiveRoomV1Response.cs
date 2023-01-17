namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/data_analysis/query_live_room 接口的响应。</para>
    /// </summary>
    public class AppsDataAnalysisQueryLiveRoomV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LiveRoom
                    {
                        /// <summary>
                        /// 获取或设置主播昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("anchor_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("anchor_name")]
                        public string AnchorName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_room_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_room_id")]
                        public long LiveRoomId { get; set; }

                        /// <summary>
                        /// 获取或设置直播间标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_room_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_room_name")]
                        public string LiveRoomName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置开播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        public long CreateTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置当前直播间列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("current_live_room")]
                [System.Text.Json.Serialization.JsonPropertyName("current_live_room")]
                public Types.LiveRoom[] CurrentLiveRoomList { get; set; } = default!;

                /// <summary>
                /// 获取或设置历史直播间列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("history_live_room")]
                [System.Text.Json.Serialization.JsonPropertyName("history_live_room")]
                public Types.LiveRoom[] HistoryLiveRoomList { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
