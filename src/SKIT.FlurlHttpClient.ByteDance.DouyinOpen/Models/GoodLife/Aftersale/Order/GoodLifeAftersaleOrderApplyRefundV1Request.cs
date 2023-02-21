using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /goodlife/v1/after_sale/order/apply_refund 接口的请求。</para>
    /// </summary>
    public class GoodLifeAftersaleOrderApplyRefundV1Request : DouyinOpenRequest
    {
        public static class Types
        {
            public class RefundReason
            {
                /// <summary>
                /// 获取或设置退款错误码列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason_code")]
                [System.Text.Json.Serialization.JsonPropertyName("reason_code")]
                public IList<int> ReasonCodeList { get; set; } = new List<int>();

                /// <summary>
                /// 获取或设置退款描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public string? Description { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_after_sale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_after_sale_id")]
        public string OutAftersaleId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款原因信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public Types.RefundReason RefundReason { get; set; } = new Types.RefundReason();
    }
}
