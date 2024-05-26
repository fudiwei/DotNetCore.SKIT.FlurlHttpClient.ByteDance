using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /live/booking/text_create/ 接口的请求。</para>
    /// </summary>
    public class LiveBookingTextCreateRequest : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公告类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("text_type")]
        [System.Text.Json.Serialization.JsonPropertyName("text_type")]
        public int TextType { get; set; }

        /// <summary>
        /// 获取或设置公告内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

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
        public IList<int>? LiveWeekdays { get; set; }
    }
}
