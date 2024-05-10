namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [GET] /product/global_products 接口的请求。</para>
    /// </summary>
    public class GlobalProductGetProductDetailRequest : TikTokShopLegacyRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? ApiVersion { get; set; } = "202306";

        /// <summary>
        /// 获取或设置全球商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string GlobalProductId { get; set; } = string.Empty;
    }
}
