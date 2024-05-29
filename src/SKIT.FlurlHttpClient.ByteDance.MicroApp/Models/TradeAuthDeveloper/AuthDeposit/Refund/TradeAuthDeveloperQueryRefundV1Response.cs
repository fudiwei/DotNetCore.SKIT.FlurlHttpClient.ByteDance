namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_refund/ 接口的响应。</para>
    /// </summary>
    public class TradeAuthDeveloperQueryRefundV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FeeDetail : TradeAuthDeveloperQueryPayOrderV1Response.Types.Data.Types.FeeDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置扣款单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
                public string PayOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置开发者退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_pay_refund_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_pay_refund_no")]
                public string OutPayRefundNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_refund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_refund_id")]
                public string PayRefundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置费用明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fee_detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("fee_detail_list")]
                public Types.FeeDetail[] FeeDetailList { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_total_amount")]
                public int RefundTotalAmount { get; set; }

                /// <summary>
                /// 获取或设置退款原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
                public string? RefundReason { get; set; }

                /// <summary>
                /// 获取或设置收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_uid")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_uid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置回调通知地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
                public string? NotifyUrl { get; set; }

                /// <summary>
                /// 获取或设置退款结果信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("message")]
                [System.Text.Json.Serialization.JsonPropertyName("message")]
                public string? ResultMessage { get; set; }

                /// <summary>
                /// 获取或设置退款时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_at")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_at")]
                public long? RefundTimeMilliseconds { get; set; }
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
