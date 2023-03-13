namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /products 接口的响应。</para>
    /// </summary>
    public class ProductDeleteProductsResponse : TikTokShopResponse<ProductDeleteProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置删除失败的商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_product_ids")]
                public string[]? FailedProductIdList { get; set; }
            }
        }
    }
}
