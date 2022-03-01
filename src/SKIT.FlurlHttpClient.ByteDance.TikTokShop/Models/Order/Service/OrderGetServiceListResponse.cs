using System;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/getServiceList 接口的响应。</para>
    /// </summary>
    public class OrderGetServiceListResponse : TikTokShopResponse<OrderGetServiceListResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Service
                    {
                        /// <summary>
                        /// 获取或设置服务请求 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public long Id { get; set; }

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string OrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务请求类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_type")]
                        public int ServiceType { get; set; }

                        /// <summary>
                        /// 获取或设置服务单详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail")]
                        public string Detail { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置操作状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_status")]
                        public int OperateStatus { get; set; }

                        /// <summary>
                        /// 获取或设置操作状态描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operate_status_desc")]
                        [System.Text.Json.Serialization.JsonPropertyName("operate_status_desc")]
                        public string OperateStatusDescription { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商家答复内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply")]
                        [System.Text.Json.Serialization.JsonPropertyName("reply")]
                        public string? ReplyDetail { get; set; }

                        /// <summary>
                        /// 获取或设置商家答复时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reply_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("reply_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? ReplyTime { get; set; }

                        /// <summary>
                        /// 获取或设置服务创建时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset UpdateTime { get; set; }

                        /// <summary>
                        /// 获取或设置服务更新时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                        public DateTimeOffset CreateTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置服务单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Service[] ServiceList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
