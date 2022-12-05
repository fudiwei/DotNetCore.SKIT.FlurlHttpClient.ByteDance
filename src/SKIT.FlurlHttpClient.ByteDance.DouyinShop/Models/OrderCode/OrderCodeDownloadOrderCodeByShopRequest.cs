namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /orderCode/downloadOrderCodeByShop 接口的请求。</para>
    /// </summary>
    public class OrderCodeDownloadOrderCodeByShopRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
        public string OrderId { get; set; } = string.Empty;
    }
}
