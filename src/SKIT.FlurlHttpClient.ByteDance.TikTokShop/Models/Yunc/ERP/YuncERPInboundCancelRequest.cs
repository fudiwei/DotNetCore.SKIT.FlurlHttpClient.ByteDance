namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /yunc/erpInboundCancel 接口的请求。</para>
    /// </summary>
    public class YuncERPInboundCancelRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
        public int ShopId { get; set; }

        /// <summary>
        /// 获取或设置单据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public int OrderType { get; set; }

        /// <summary>
        /// 获取或设置入库单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_order_no")]
        public string BusinessOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置取消原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_reason")]
        public string CancelReason { get; set; } = string.Empty;
    }
}
