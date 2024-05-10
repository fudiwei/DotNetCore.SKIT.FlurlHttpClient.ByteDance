namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/recover 接口的响应。</para>
    /// </summary>
    public class ProductRecoverProductsResponse : TikTokShopLegacyResponse<ProductRecoverProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置恢复失败的商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_product_ids")]
                public string[]? FailedProductIdList { get; set; }
            }
        }
    }
}
