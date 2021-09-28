namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/qualityTask 接口的请求。</para>
    /// </summary>
    public class ProductQualityTaskRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置是否只返回简要信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brief_only")]
        [System.Text.Json.Serialization.JsonPropertyName("brief_only")]
        public bool? IsBriefOnly { get; set; }
    }
}
