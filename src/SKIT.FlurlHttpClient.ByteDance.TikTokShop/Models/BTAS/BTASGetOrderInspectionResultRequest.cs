namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /btas/getOrderInspectionResult 接口的请求。</para>
    /// </summary>
    public class BTASGetOrderInspectionResultRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_code")]
        [System.Text.Json.Serialization.JsonPropertyName("order_code")]
        public string OrderCode { get; set; } = string.Empty;
    }
}
