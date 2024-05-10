namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [PUT] /product/global_products/prices 接口的响应。</para>
    /// </summary>
    public class GlobalProductUpdateProductPriceResponse : TikTokShopLegacyResponse<GlobalProductUpdateProductPriceResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class FailedGlobalSKU
                    {
                        /// <summary>
                        /// 获取或设置店铺所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置全球 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("global_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("global_sku_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string GlobalSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置本地 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_sku_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string LocalSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置失败原因编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("failed_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("failed_code")]
                        public int FailReasonCode { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("failed_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("failed_msg")]
                        public string? FailReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置更新失败的全球 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("failed_skus")]
                [System.Text.Json.Serialization.JsonPropertyName("failed_skus")]
                public Types.FailedGlobalSKU[]? FailedGlobalSKUList { get; set; }
            }
        }
    }
}
