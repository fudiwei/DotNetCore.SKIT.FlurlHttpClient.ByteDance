using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/getSettleBillDetail 接口的请求。</para>
    /// </summary>
    public class OrderGetSettleBillDetailRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置筛选时间类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_type")]
        [System.Text.Json.Serialization.JsonPropertyName("time_type")]
        public int TimeType { get; set; }

        /// <summary>
        /// 获取或设置查询开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// 获取或设置查询结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置结算账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
        public int? PayType { get; set; }

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("flow_type")]
        [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
        public int? FlowType { get; set; }

        /// <summary>
        /// 获取或设置翻页页数。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int PageNumber { get; set; } = 0;

        /// <summary>
        /// 获取或设置翻页每页数量。
        /// <para>默认值：20</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int PageSize { get; set; } = 20;
    }
}
