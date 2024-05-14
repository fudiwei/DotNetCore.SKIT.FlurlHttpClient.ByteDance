using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/refunds/calculate 接口的请求。</para>
    /// </summary>
    public class ReturnRefundCalculateRefundRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class SKU : ReturnRefundCreateReturnRequest.Types.SKU
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
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason_name")]
        [System.Text.Json.Serialization.JsonPropertyName("reason_name")]
        public string RequestReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_type")]
        [System.Text.Json.Serialization.JsonPropertyName("request_type")]
        public string RequestType { get; set; } = string.Empty;

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
