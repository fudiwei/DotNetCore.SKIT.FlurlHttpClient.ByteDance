namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [DELETE] /product/global_products 接口的响应。</para>
    /// </summary>
    public class GlobalProductDeleteProductsResponse : TikTokShopLegacyResponse<GlobalProductDeleteProductsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置删除失败的全球商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_global_product_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_global_product_ids")]
                public string[]? FailedGlobalProductIdList { get; set; }
            }
        }
    }
}
