namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/orderDetail 接口的请求。</para>
    /// </summary>
    public class OrderDetailRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置店铺订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        public string ShopOrderId { get; set; } = string.Empty;
    }
}
