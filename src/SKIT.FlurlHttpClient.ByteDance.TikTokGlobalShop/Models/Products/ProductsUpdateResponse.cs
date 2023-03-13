namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /products 接口的响应。</para>
    /// </summary>
    public class ProductsUpdateResponse : TikTokShopResponse<ProductsUpdateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : ProductsCreateResponse.Types.Data
            {
                public static new class Types
                {
                    public class SKU : ProductsCreateResponse.Types.Data.Types.SKU
                    {
                        public static new class Types
                        {
                            public class SalesAttribute : ProductsCreateResponse.Types.Data.Types.SKU.Types.SalesAttribute
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
