namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/addressConfirm 接口的请求。</para>
    /// </summary>
    public class OrderAddressConfirmRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置确认类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_approved")]
        [System.Text.Json.Serialization.JsonPropertyName("is_approved")]
        public int ApprovedType { get; set; }
    }
}
