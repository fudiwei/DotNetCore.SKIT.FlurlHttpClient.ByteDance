namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /return_refund/{version}/returns/{return_id}/approve 接口的请求。</para>
    /// </summary>
    public class ReturnRefundApproveReturnRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置退货 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ReturnId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置决定。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("decision")]
        [System.Text.Json.Serialization.JsonPropertyName("decision")]
        public string Decision { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置买家是否保留货物。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_keep_item")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_keep_item")]
        public bool? IsBuyerKeepItem { get; set; }
    }
}
