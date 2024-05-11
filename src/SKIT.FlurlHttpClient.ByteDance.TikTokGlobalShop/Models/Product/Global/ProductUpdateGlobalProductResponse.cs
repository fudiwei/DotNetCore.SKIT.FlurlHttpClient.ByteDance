namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /product/{version}/global_products/{global_product_id} 接口的响应。</para>
    /// </summary>
    public class ProductUpdateGlobalProductResponse : TikTokShopResponse<ProductUpdateGlobalProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class SKU : ProductPublishGlobalProductResponse.Types.Data.Types.Product.Types.SKU
                    {
                    }

                    public class PublishResult : ProductPublishGlobalProductResponse.Types.Data.Types.PublishResult
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("global_skus")]
                [System.Text.Json.Serialization.JsonPropertyName("global_skus")]
                public Types.SKU[] SKUList { get; set; } = default!;

                /// <summary>
                /// 获取或设置发布结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_results")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_results")]
                public Types.PublishResult[] PublishResultList { get; set; } = default!;
            }
        }
    }
}
