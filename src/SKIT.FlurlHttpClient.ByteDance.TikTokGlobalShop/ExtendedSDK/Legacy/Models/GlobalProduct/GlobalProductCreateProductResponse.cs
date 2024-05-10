namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/global_products 接口的响应。</para>
    /// </summary>
    public class GlobalProductCreateProductResponse : TikTokShopLegacyResponse<GlobalProductCreateProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class GlobalSKU
                    {
                        public static class Types
                        {
                            public class SalesAttribute : ProductCreateProductResponse.Types.Data.Types.SKU.Types.SalesAttribute
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置全球 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("global_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("global_sku_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string GlobalSKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置销售属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                        public Types.SalesAttribute[] SalesAttributeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置卖家 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                        public string? SellerSKU { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置全球商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("global_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("global_product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string GlobalProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置全球 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.GlobalSKU[] GlobalSKUList { get; set; } = default!;
            }
        }
    }
}
