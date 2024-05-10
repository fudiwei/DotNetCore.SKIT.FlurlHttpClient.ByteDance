namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [PUT] /products/prices 接口的响应。</para>
    /// </summary>
    public class ProductUpdateProductPriceResponse : TikTokShopLegacyResponse<ProductUpdateProductPriceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置更新失败的 SKU ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_sku_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_sku_ids")]
                public string[]? FailedSKUIdList { get; set; }
            }
        }
    }
}
