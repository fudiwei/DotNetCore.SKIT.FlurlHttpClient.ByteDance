namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /room/data/audience/get/ 接口的响应。</para>
    /// </summary>
    public class RoomDataAudienceGetResponse : DouyinOpenResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class DataReadyStatusInfo : RoomDataInteractiveGetResponse.Types.Data.Types.DataReadyStatusInfo
                    {
                    }

                    public class Statistics : RoomDataInteractiveGetResponse.Types.Data.Types.Statistics
                    {
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
