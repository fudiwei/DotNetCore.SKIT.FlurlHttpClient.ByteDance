namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /product/{version}/products/{product_id} 接口的响应。</para>
    /// </summary>
    public class ProductUpdateProductResponse : TikTokShopResponse<ProductUpdateProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SKU : ProductCreateProductResponse.Types.Data.Types.SKU
                    {
                    }

                    public class Warning : ProductCreateProductResponse.Types.Data.Types.Warning
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string ProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public Types.SKU[] SKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置警告列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("warnings")]
                [System.Text.Json.Serialization.JsonPropertyName("warnings")]
                public Types.Warning[]? WarningList { get; set; }
            }
        }
    }
}
