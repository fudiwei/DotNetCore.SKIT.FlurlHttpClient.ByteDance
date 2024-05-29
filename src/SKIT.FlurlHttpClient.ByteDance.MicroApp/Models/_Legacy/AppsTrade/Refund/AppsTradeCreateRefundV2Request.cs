using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/trade/v2/create_refund 接口的请求。</para>
    /// </summary>
    public class AppsTradeCreateRefundV2Request : DouyinMicroAppRequest
    {
        public static class Types
        {
            public class ItemOrder : TradeBasicDeveloperRefundCreateV1Request.Types.ItemOrder
            {
            }

            public class MicroAppSchema : TradeBasicDeveloperRefundCreateV1Request.Types.MicroAppSchema
            {
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
        /// 获取或设置退款单详情页的 Schema。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_entry_schema")]
        [System.Text.Json.Serialization.JsonPropertyName("order_entry_schema")]
        public Types.MicroAppSchema? OrderEntrySchema { get; set; }
    }
}
