namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /afterSale/Detail 接口的请求。</para>
    /// </summary>
    public class AftersaleDetailRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_id")]
        public string AftersaleId { get; set; } = string.Empty;
    }
}
