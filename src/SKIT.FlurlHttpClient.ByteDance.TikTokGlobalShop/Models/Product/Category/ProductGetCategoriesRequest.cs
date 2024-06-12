namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories 接口的请求。</para>
    /// </summary>
    public class ProductGetCategoriesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置关键字。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置分类版本。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CategoryVersion { get; set; }

        /// <summary>
        /// 获取或设置本地化语种。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Locale { get; set; }
    }
}
