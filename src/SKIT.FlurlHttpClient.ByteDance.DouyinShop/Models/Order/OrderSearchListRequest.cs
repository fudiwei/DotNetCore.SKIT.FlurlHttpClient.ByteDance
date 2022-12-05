using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/searchList 接口的请求。</para>
    /// </summary>
    public class OrderSearchListRequest : DouyinShopRequest
    {
        public static class Types
        {
            public class CombineStatus
            {
                /// <summary>
                /// 获取或设置订单状态列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerListWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerListWithCommaSplitConverter))]
                public IList<int>? OrderStatusList { get; set; }

                /// <summary>
                /// 获取或设置主流程状态列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_status")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerListWithCommaSplitConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("main_status")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualIntegerListWithCommaSplitConverter))]
                public IList<int>? MainStatusList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID 或名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_id")]
        public string? ProductIdOrName { get; set; }

        /// <summary>
        /// 获取或设置下单端类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("b_type")]
        [System.Text.Json.Serialization.JsonPropertyName("b_type")]
        public int? BillType { get; set; }

        /// <summary>
        /// 获取或设置售后状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_status_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_status_desc")]
        public string? AftersaleStatusDescription { get; set; }

        /// <summary>
        /// 获取或设置物流单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tracking_no")]
        [System.Text.Json.Serialization.JsonPropertyName("tracking_no")]
        public string? LogisticsNumber { get; set; }

        /// <summary>
        /// 获取或设置预售类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presell_type")]
        [System.Text.Json.Serialization.JsonPropertyName("presell_type")]
        public int? PresellType { get; set; }

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int? OrderType { get; set; }

        /// <summary>
        /// 获取或设置下单时间范围开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_start")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_start")]
        public long? CreateTimeStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置下单时间范围结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time_end")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time_end")]
        public long? CreateTimeEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_start")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_start")]
        public long? UpdateTimeStartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置更新时间范围结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time_end")]
        [System.Text.Json.Serialization.JsonPropertyName("update_time_end")]
        public long? UpdateTimeEndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置异常订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abnormal_order")]
        [System.Text.Json.Serialization.JsonPropertyName("abnormal_order")]
        public int? AbnormalOrderType { get; set; }

        /// <summary>
        /// 获取或设置交易类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_type")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_type")]
        public int? TradeType { get; set; }

        /// <summary>
        /// 获取或设置组合状态信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_status")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_status")]
        public Types.CombineStatus? CombineStatus { get; set; }

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
        [Newtonsoft.Json.JsonProperty("order_asc")]
        [System.Text.Json.Serialization.JsonPropertyName("order_asc")]
        public bool? SortByAscending { get; set; }

        /// <summary>
        /// 获取或设置排序字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by")]
        [System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? SortField { get; set; }
    }
}
