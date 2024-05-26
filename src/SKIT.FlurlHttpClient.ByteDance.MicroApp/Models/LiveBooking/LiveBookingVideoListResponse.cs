namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /live/booking/video_list/ 接口的响应。</para>
    /// </summary>
    public class LiveBookingVideoListResponse : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Booking
                    {
                        /// <summary>
                        /// 获取或设置预约 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("booking_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("booking_id")]
                        public string BookingId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置预计开播时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("live_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("live_time")]
                        public long LiveTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置主播 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("anchor_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("anchor_id")]
                        public long AnchorId { get; set; }

                        /// <summary>
                        /// 获取或设置视频 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("video_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                        public string VideoId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置额外信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra")]
                        public string? Extra { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置预约列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Booking[] BookingList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
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
