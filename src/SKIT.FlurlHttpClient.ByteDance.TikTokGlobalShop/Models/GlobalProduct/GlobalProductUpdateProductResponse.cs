namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /product/global_products 接口的响应。</para>
    /// </summary>
    public class GlobalProductUpdateProductResponse : TikTokShopResponse<GlobalProductUpdateProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LocalProduct
                    {
                        /// <summary>
                        /// 获取或设置店铺所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_product_region")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_product_region")]
                        public string Region { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置本地商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_product_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string LocalProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置编辑结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_product_edit_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_product_edit_result")]
                        public int EditResult { get; set; }
                    }

                    public class GlobalSKU
                    {
                        public static class Types
                        {
                            public class SalesAttribute
                            {
                                /// <summary>
                                /// 获取或设置属性 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string AttributeId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string AttributeName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string ValueId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置属性值名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_name")]
                                public string ValueName { get; set; } = default!;
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
                        /// 获取或设置卖家 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                        public string? SellerSKU { get; set; }

                        /// <summary>
                        /// 获取或设置销售属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_property")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_property")]
                        public Types.SalesAttribute[] SalesAttributeList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置全球商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string GlobalProductId { get; set; } = default!;

                /// <summary>
                /// 获取或设置本地商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("local_product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("local_product_info")]
                public Types.LocalProduct[] LocalProductList { get; set; } = default!;

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
