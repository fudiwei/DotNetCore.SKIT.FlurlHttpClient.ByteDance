namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /iop/orderInfo 接口的请求。</para>
    /// </summary>
    public class IOPOrderInformationRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置代打店铺 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_id")]
        [System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long DistributeShopId { get; set; }

        /// <summary>
        /// 获取或设置代打订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distr_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("distr_order_id")]
        public string DistributeOrderId { get; set; } = string.Empty;
    }
}
