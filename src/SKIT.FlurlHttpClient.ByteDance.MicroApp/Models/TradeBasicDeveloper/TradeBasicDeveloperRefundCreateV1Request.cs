using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/refund_create/ 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperRefundCreateV1Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class ItemOrder
            {
                /// <summary>
                /// 获取或设置商品单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("item_order_id")]
                public string ItemOrderId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
                public int RefundAmount { get; set; }
            }

            public class RefundReason
            {
                /// <summary>
                /// 获取或设置退款原因编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                public int Code { get; set; }

                /// <summary>
                /// 获取或设置退款原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string Text { get; set; } = string.Empty;
            }

            public class MicroAppSchema
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string Path { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面参数字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("params")]
                [System.Text.Json.Serialization.JsonPropertyName("params")]
                public string? ParamsString { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开发者退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退款总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_total_amount")]
        public int RefundTotalAmount { get; set; }

        /// <summary>
        /// 获取或设置商品单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("item_order_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("item_order_detail")]
        public IList<Types.ItemOrder>? ItemOrderList { get; set; }

        /// <summary>
        /// 获取或设置是否整单退款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_all")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_all")]
        public bool? IsRefundAll { get; set; }

        /// <summary>
        /// 获取或设置退款原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_reason")]
        public IList<Types.RefundReason> RefundReasonList { get; set; } = new List<Types.RefundReason>();

        /// <summary>
        /// 获取或设置自定义字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cp_extra")]
        [System.Text.Json.Serialization.JsonPropertyName("cp_extra")]
        public string? Extra { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置退款单详情页的 Schema。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_entry_schema")]
        [System.Text.Json.Serialization.JsonPropertyName("order_entry_schema")]
        public Types.MicroAppSchema? OrderEntrySchema { get; set; }
    }
}
