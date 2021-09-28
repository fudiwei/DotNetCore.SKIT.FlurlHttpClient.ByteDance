using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /member/searchList 接口的请求。</para>
    /// </summary>
    public class MemberSearchListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置范围起始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置范围结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? PageSize { get; set; }
    }
}
