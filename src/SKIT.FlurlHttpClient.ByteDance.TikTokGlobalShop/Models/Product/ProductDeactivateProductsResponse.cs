namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/products/deactivate 接口的响应。</para>
    /// </summary>
    public class ProductDeactivateProductsResponse : TikTokShopResponse<ProductActivateProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ProductActivateProductsResponse.Types.Data
            {
            }
        }
    }
}
