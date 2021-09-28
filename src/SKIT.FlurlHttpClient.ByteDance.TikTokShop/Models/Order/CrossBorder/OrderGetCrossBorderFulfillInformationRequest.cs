namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/getCrossBorderFulfillInfo 接口的请求。</para>
    /// </summary>
    public class OrderGetCrossBorderFulfillInformationRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置店铺订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        public string ShopOrderId { get; set; } = string.Empty;
    }
}
