using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /crossBorder/orderList 接口的请求。</para>
    /// </summary>
    public class CrossBorderOrderListRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置服务商编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vendor")]
        [System.Text.Json.Serialization.JsonPropertyName("vendor")]
        public string VendorCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置订单 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("order_list")]
        public IList<string>? OrderIdList { get; set; }

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

        /// <summary>
        /// 获取或设置排序方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_desc")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_desc")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? SortByDescending { get; set; }

        /// <summary>
        /// 获取或设置排序字段。
        /// <para>默认值：create_time</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by")]
        [System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string SortField { get; set; } = "create_time";
    }
}
