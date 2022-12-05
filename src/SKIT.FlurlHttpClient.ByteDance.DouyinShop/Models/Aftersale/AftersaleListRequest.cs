using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/List 接口的请求。</para>
    /// </summary>
    public class AftersaleListRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public string? AftersaleId { get; set; }

        /// <summary>
        /// 获取或设置订单标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("order_flag")]
        public IList<int>? OrderFlagList { get; set; }

        /// <summary>
        /// 获取或设置风控标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_flag")]
        public int? RiskFlag { get; set; }

        /// <summary>
        /// 获取或设置开始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.UnixTimestampNullableDateTimeOffsetConverter))]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// 获取或设置售后类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_type")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_type")]
        public int? AftersaleType { get; set; }

        /// <summary>
        /// 获取或设置售后状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_status")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_status")]
        public int? AftersaleStatus { get; set; }

        /// <summary>
        /// 获取或设置售后理由类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public int? AftersaleReasonType { get; set; }

        /// <summary>
        /// 获取或设置支付方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
        public int? PayType { get; set; }

        /// <summary>
        /// 获取或设置退款类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_type")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_type")]
        public int? RefundType { get; set; }

        /// <summary>
        /// 获取或设置仲裁状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("arbitrate_status")]
        [System.Text.Json.Serialization.JsonPropertyName("arbitrate_status")]
        public int? ArbitrateStatus { get; set; }

        /// <summary>
        /// 获取或设置物流状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logistics_status")]
        [System.Text.Json.Serialization.JsonPropertyName("logistics_status")]
        public int? LogisticsStatus { get; set; }

        /// <summary>
        /// 获取或设置金额下限（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount_start")]
        [System.Text.Json.Serialization.JsonPropertyName("amount_start")]
        public int? StartAmount { get; set; }

        /// <summary>
        /// 获取或设置金额上限（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount_end")]
        [System.Text.Json.Serialization.JsonPropertyName("amount_end")]
        public int? EndAmount { get; set; }

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
        /// 获取或设置排序字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by")]
        [System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public IList<string>? SortFields { get; set; }
    }
}
