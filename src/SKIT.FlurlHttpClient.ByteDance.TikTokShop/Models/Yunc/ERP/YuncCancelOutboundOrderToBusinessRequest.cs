namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/cancelOutboundOrderToB 接口的请求。</para>
    /// </summary>
    public class YuncCancelOutboundOrderToBusinessRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置 ERP 出库单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("erp_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("erp_order_no")]
        public string ERPOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("op_type")]
        [System.Text.Json.Serialization.JsonPropertyName("op_type")]
        public int? OperateType { get; set; }

        /// <summary>
        /// 获取或设置	操作标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_tag")]
        public int? CancelTag { get; set; }

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string? CancelReason { get; set; }
    }
}
