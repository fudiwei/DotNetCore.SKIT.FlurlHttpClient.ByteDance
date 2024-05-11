namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/recover 接口的响应。</para>
    /// </summary>
    public class ProductRecoverProductsResponse : TikTokShopResponse<ProductRecoverProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ProductDeleteProductsResponse.Types.Data
            {
            }
        }
    }
}
