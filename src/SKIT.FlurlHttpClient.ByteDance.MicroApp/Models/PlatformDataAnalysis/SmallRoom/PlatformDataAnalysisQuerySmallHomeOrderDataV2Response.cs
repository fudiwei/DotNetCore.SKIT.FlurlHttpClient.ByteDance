using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /api/platform/v2/data_analysis/query_small_home_order_data/ 接口的响应。</para>
    /// </summary>
    public class PlatformDataAnalysisQuerySmallHomeOrderDataV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SmallHomeOrderData
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("app_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                        public string AppName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主播 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("anchor_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("anchor_id")]
                        public string AnchorId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主播昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string AnchorNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                        public string LiveRoomId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                        public string OrderStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置核销订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_success_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_success_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long DeliverySuccessAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置支付时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_success_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_success_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long RefundSuccessAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                public string AppName { get; set; } = default!;

                /// <summary>
                /// 获取或设置小房子直播间数据字典。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_data")]
                [System.Text.Json.Serialization.JsonPropertyName("order_data")]
                public IDictionary<string, Types.SmallHomeOrderData> SmallHomeRoomDataMap { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否还有更多数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_num")]
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
