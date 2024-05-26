namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /live/booking/text_detail/ 接口的响应。</para>
    /// </summary>
    public class LiveBookingTextDetailResponse : DouyinMicroAppResponse
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
                /// 获取或设置主播 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("anchor_id")]
                [System.Text.Json.Serialization.JsonPropertyName("anchor_id")]
                public long AnchorId { get; set; }

                /// <summary>
                /// 获取或设置公告内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置开播时间字符串（格式：HHmm）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("live_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string? LiveTimeString { get; set; }

                /// <summary>
                /// 获取或设置开播日期字符串（格式：yyyyMMdd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_date")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalStringConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("live_date")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringConverter))]
                public string? LiveDateString { get; set; }

                /// <summary>
                /// 获取或设置开播日列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("live_weekdays")]
                [System.Text.Json.Serialization.JsonPropertyName("live_weekdays")]
                public int[]? LiveWeekdays { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置是否已预约。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_booking")]
        [System.Text.Json.Serialization.JsonPropertyName("has_booking")]
        public bool HasBooking { get; set; }

        /// <summary>
        /// 获取或设置预约信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_booking")]
        [System.Text.Json.Serialization.JsonPropertyName("text_booking")]
        public Types.Booking Booking { get; set; } = default!;
    }
}
