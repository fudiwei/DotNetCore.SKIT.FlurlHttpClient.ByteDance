namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/global_products/publish 接口的响应。</para>
    /// </summary>
    public class GlobalProductPublishProductResponse : TikTokShopResponse<GlobalProductPublishProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Result
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                public static class Types
                                {
                                    public class Attribute
                                    {
                                        /// <summary>
                                        /// 获取或设置属性 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("attribute_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("attribute_id")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                        public string AttributeId { get; set; } = default!;

                                        /// <summary>
                                        /// 获取或设置属性值 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("value_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("value_id")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                        public string ValueId { get; set; } = default!;
                                    }
                                }

                                /// <summary>
                                /// 获取或设置全球 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("global_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("global_sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string GlobalSKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置本地 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("local_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("local_sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                                public string LocalSKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置本地卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("local_seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("local_seller_sku")]
                                public string? LocalSellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU 属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("local_sale_attributes")]
                                [System.Text.Json.Serialization.JsonPropertyName("local_sale_attributes")]
                                public Types.Attribute[] AttributeList { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string ShopId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺所在地。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_region")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_region")]
                        public string ShopRegion { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置发布结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_product_publish_result")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_product_publish_result")]
                        public int PublishResult { get; set; }

                        /// <summary>
                        /// 获取或设置本地商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("local_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("local_product_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                        public string LocalProductId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public Types.SKU[] SKUList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_list")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_list")]
                public Types.Result[] ResultList { get; set; } = default!;
            }
        }
    }
}
