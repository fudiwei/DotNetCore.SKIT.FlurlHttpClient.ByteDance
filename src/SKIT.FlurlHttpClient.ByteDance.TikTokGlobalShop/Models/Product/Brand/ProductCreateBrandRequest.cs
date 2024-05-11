namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/brands 接口的请求。</para>
    /// </summary>
    public class ProductCreateBrandRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置品牌名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
