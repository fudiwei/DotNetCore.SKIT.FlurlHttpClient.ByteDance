using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/returns 接口的请求。</para>
    /// </summary>
    public class ReturnRefundCreateReturnRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class SKU : ReturnRefundCreateCancellationRequest.Types.SKU
            {
            }
        }

        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单行 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_line_item_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("order_line_item_ids")]
        public IList<string>? OrderLineItemIdList { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU>? SKUList { get; set; }

        /// <summary>
        /// 获取或设置退货原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("return_reason")]
        public string ReturnReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置退货类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("return_type")]
        [System.Text.Json.Serialization.JsonPropertyName("return_type")]
        public string ReturnType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置币种。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency")]
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// 获取或设置退款金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_total")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("refund_total")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public decimal? RefundTotal { get; set; }

        /// <summary>
        /// 获取或设置运输类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shipment_type")]
        [System.Text.Json.Serialization.JsonPropertyName("shipment_type")]
        public string? ShipmentType { get; set; }

        /// <summary>
        /// 获取或设置交接方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("handover_method")]
        [System.Text.Json.Serialization.JsonPropertyName("handover_method")]
        public string? HandoverMethod { get; set; }
    }
}
