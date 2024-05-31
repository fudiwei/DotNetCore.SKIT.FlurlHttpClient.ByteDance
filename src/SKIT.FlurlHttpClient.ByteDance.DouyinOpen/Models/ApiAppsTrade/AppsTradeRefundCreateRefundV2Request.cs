using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/refund/create_refund 接口的请求。</para>
    /// </summary>
    public class AppsTradeRefundCreateRefundV2Request : DouyinOpenRequest
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

            public class TimesCardRefundParameter
            {
                /// <summary>
                /// 获取或设置退款类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("times_card_refund_type")]
                [System.Text.Json.Serialization.JsonPropertyName("times_card_refund_type")]
                public int RefundType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置开发者订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string OutOrderNumber { get; set; } = string.Empty;

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
        /// 获取或设置次卡退款参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("times_card_refund_param")]
        [System.Text.Json.Serialization.JsonPropertyName("times_card_refund_param")]
        public Types.TimesCardRefundParameter? TimesCardRefundParameter { get; set; }

        /// <summary>
        /// 获取或设置订单详情页的 Schema。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_entry_schema")]
        [System.Text.Json.Serialization.JsonPropertyName("order_entry_schema")]
        public Types.MicroAppSchema? OrderEntrySchema { get; set; }
    }
}
