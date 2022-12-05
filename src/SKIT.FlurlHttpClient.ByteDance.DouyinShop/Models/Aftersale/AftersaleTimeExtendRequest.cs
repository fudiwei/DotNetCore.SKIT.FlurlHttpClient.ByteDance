namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/timeExtend 接口的请求。</para>
    /// </summary>
    public class AftersaleTimeExtendRequest : DouyinShopRequest
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public string AftersaleId { get; set; } = string.Empty;
    }
}
