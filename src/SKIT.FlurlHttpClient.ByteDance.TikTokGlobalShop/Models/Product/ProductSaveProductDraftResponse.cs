namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/save_draft 接口的响应。</para>
    /// </summary>
    public class ProductSaveProductDraftResponse : TikTokShopResponse<ProductSaveProductDraftResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ProductCreateProductResponse.Types.Data
            {
                public static new class Types
                {
                    public class SKU : ProductCreateProductResponse.Types.Data.Types.SKU
                    {
                        public static new class Types
                        {
                            public class SalesAttribute : ProductCreateProductResponse.Types.Data.Types.SKU.Types.SalesAttribute
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置销售属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_attributes")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                        public new Types.SalesAttribute[] SalesAttributeList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public new Types.SKU[] SKUList { get; set; } = default!;
            }
        }
    }
}
