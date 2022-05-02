namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /apps/ecpay/v1/query_refund 接口的响应。</para>
    /// </summary>
    public class AppsECPayQueryRefundV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Refund
            {
                /// <summary>
                /// 获取或设置担保交易退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_no")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_no")]
                public string RefundNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_status")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
                public string RefundStatus { get; set; } = default!;
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_tips")]
        [System.Text.Json.Serialization.JsonPropertyName("err_tips")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置退款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refundInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("refundInfo")]
        public Types.Refund Refund { get; set; } = default!;
    }
}
