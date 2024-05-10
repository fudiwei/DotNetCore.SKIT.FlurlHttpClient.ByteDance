namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [PUT] /products/stocks 接口的响应。</para>
    /// </summary>
    public class ProductUpdateProductStockResponse : TikTokShopLegacyResponse<ProductUpdateProductStockResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailedSKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置更新失败的仓库 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("failed_warehouse_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("failed_warehouse_ids")]
                        public string[] FailedWarehouseIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置更新失败的 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_skus")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_skus")]
                public Types.FailedSKU[]? FailedSKUList { get; set; }
            }
        }
    }
}
