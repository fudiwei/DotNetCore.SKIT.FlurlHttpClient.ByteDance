namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/query_item_order_info 接口的响应。</para>
    /// </summary>
    public class AppsTradeQueryItemOrderInfoV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
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
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data[] Data { get; set; } = default!;
    }
}
