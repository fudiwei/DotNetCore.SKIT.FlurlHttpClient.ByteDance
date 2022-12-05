namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /order/serviceDetail 接口的请求。</para>
    /// </summary>
    public class OrderServiceDetailRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置服务单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;
    }
}
