namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/create_refund 接口的响应。</para>
    /// </summary>
    public class AppsTradeCreateRefundV2Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_id")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
                public string RefundId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核的最后期限毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_audit_deadline")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_audit_deadline")]
                public long AuditDeadlineMilliseconds { get; set; }
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
