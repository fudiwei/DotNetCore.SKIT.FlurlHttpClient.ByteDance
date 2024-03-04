namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/pre_check 接口的请求。</para>
    /// </summary>
    public class ProductPrecheckRequest : TikTokShopRequest
    {
        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? ApiVersion { get; set; } = "202306";
    }
}
