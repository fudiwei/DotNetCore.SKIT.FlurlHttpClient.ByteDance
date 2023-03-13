namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /products/details 接口的请求。</para>
    /// </summary>
    public class ProductGetProductDetailRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否返回审核中的版本。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public bool? RequireAuditVersion { get; set; }
    }
}
