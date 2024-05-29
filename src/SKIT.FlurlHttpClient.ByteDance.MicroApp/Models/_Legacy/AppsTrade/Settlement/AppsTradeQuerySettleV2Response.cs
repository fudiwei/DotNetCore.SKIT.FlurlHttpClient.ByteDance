namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/query_settle 接口的响应。</para>
    /// </summary>
    public class AppsTradeQuerySettleV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发者订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
                public string OutOrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发者分账单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_settle_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_settle_no")]
                public string OutSettleNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_id")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_id")]
                public string SettleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置内部分账单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("inner_settle_id")]
                [System.Text.Json.Serialization.JsonPropertyName("inner_settle_id")]
                public string InnerSettleId { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_status")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                public string? ItemOrderId { get; set; }

                /// <summary>
                /// 获取或设置自定义字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cp_extra")]
                [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
                public string? Extra { get; set; }

                /// <summary>
                /// 获取或设置分账详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_detail")]
                public string SettleDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置手续费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("rake")]
                [System.Text.Json.Serialization.JsonPropertyName("rake")]
                public int RakeFee { get; set; }

                /// <summary>
                /// 获取或设置佣金金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission")]
                [System.Text.Json.Serialization.JsonPropertyName("commission")]
                public int CommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                public int SettleAmount { get; set; }

                /// <summary>
                /// 获取或设置分账时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                public long? SettleTimeMilliseconds { get; set; }
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
