namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /room/data/interactive/get/ 接口的响应。</para>
    /// </summary>
    public class RoomDataInteractiveGetResponse : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DataReadyStatusInfo
                    {
                        /// <summary>
                        /// 获取或设置业务线 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_id")]
                        public int LiveId { get; set; }

                        /// <summary>
                        /// 获取或设置业务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_type")]
                        public int ItemType { get; set; }

                        /// <summary>
                        /// 获取或设置指标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("time_slot")]
                        [System.Text.Json.Serialization.JsonPropertyName("time_slot")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置是否已就绪。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_ready")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_ready")]
                        public bool IsReady { get; set; }
                    }

                    public class Statistics
                    {
                        /// <summary>
                        /// 获取或设置业务线 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_id")]
                        public int LiveId { get; set; }

                        /// <summary>
                        /// 获取或设置业务类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_type")]
                        public int ItemType { get; set; }

                        /// <summary>
                        /// 获取或设置业务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item")]
                        [System.Text.Json.Serialization.JsonPropertyName("item")]
                        public string ItemId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置指标名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置日期字符串（格式：yyyy-MM-dd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("timeslot")]
                        [System.Text.Json.Serialization.JsonPropertyName("timeslot")]
                        public string DateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置指标值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        public int? Value { get; set; }

                        /// <summary>
                        /// 获取或设置指标值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value_float")]
                        [System.Text.Json.Serialization.JsonPropertyName("value_float")]
                        public decimal? ValueAsFloat { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置数据就绪状态列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data_ready_status")]
                [System.Text.Json.Serialization.JsonPropertyName("data_ready_status")]
                public Types.DataReadyStatusInfo[] DataReadyStatusList { get; set; } = default!;

                /// <summary>
                /// 获取或设置统计数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stats")]
                [System.Text.Json.Serialization.JsonPropertyName("stats")]
                public Types.Statistics[] StatisticsList { get; set; } = default!;
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
