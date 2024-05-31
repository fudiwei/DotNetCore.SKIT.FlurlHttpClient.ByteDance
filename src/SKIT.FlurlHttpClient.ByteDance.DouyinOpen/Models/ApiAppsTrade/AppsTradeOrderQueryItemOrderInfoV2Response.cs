namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/order/query_item_order_info 接口的响应。</para>
    /// </summary>
    public class AppsTradeOrderQueryItemOrderInfoV2Response : DouyinOpenResponse<AppsTradeOrderQueryItemOrderInfoV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class ItemOrder
                    {
                        public static class Types
                        {
                            public class TimesCardInfo
                            {
                                /// <summary>
                                /// 获取或设置总次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("total_times")]
                                [System.Text.Json.Serialization.JsonPropertyName("total_times")]
                                public int TotalTimes { get; set; }

                                /// <summary>
                                /// 获取或设置可用次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("usable_times")]
                                [System.Text.Json.Serialization.JsonPropertyName("usable_times")]
                                public int UsableTimes { get; set; }

                                /// <summary>
                                /// 获取或设置退款次数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_times")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_times")]
                                public int RefundTimes { get; set; }

                                /// <summary>
                                /// 获取或设置单次现价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_amount_once")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_amount_once")]
                                public int? ActualOnceAmount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                        public string ItemOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品单状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_order_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_order_status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置有效期开始时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_start_time")]
                        public long ValidStartTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置有效期结束时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("valid_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("valid_end_time")]
                        public long ValidEndTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置核销时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_time")]
                        public long DeliveryTimeMilliseconds { get; set; }

                        /// <summary>
                        /// 获取或设置次卡信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("times_card_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("times_card_info")]
                        public Types.TimesCardInfo? TimesCardInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_list")]
                [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                public Types.ItemOrder[] ItemOrderList { get; set; } = default!;
            }
        }
    }
}
