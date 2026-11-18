namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /product/{version}/products 接口的响应。</para>
    /// </summary>
    public class ProductDeleteProductsResponse : TikTokShopResponse<ProductDeleteProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置失败的商品 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_product_ids")]
                public List<string>? FailedProductIdList { get; set; }
            }
        }
    }
}
