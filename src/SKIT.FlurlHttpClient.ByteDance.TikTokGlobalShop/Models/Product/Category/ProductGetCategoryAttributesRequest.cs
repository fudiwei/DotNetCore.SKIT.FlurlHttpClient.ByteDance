namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/{version}/categories/{category_id}/attributes 接口的请求。</para>
    /// </summary>
    public class ProductGetCategoryAttributesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CategoryId { get; set; } = string.Empty;

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
