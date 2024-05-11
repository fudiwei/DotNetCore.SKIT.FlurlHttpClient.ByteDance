namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/global_categories 接口的请求。</para>
    /// </summary>
    public class ProductGetGlobalCategoriesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置本地化语种。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Locale { get; set; }
    }
}
