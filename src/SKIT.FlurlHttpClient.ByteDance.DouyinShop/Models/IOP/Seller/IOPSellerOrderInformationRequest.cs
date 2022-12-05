namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/sellerOrderInfo 接口的请求。</para>
    /// </summary>
    public class IOPSellerOrderInformationRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置代打订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
        public string DistributeOrderId { get; set; } = string.Empty;
    }
}
