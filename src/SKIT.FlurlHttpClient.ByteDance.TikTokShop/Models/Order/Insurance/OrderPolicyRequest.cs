namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/policy 接口的请求。</para>
    /// </summary>
    public class OrderPolicyRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险产品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ins_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ins_product_id")]
        public string InsuraceProductType { get; set; } = string.Empty;
    }
}
