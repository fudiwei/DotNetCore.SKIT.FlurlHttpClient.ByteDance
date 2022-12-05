using System;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/OrderInterception 接口的请求。</para>
    /// </summary>
    public class CrossBorderOrderInterceptionRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置服务商编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendor")]
        [System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string VendorCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置交易单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发生时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("occurrence_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("occurrence_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset OccurrenceTime { get; set; }

        /// <summary>
        /// 获取或设置状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }
    }
}
