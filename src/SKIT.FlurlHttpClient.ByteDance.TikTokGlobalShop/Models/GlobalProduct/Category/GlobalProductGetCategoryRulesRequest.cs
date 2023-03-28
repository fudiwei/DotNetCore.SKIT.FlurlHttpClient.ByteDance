namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/global_products/categories/rules 接口的请求。</para>
    /// </summary>
    public class GlobalProductGetCategoryRulesRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CategoryId { get; set; } = string.Empty;
    }
}
