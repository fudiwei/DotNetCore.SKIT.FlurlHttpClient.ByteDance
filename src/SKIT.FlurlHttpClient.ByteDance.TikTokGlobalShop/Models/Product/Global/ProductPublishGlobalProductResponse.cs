namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_products/{global_product_id}/publish 接口的响应。</para>
    /// </summary>
    public class ProductPublishGlobalProductResponse : TikTokShopResponse<ProductPublishGlobalProductResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class SKU
                            {
                                public static class Types
                                {
                                    public class SalesAttribute : ProductCreateGlobalProductResponse.Types.Data.Types.SKU.Types.SalesAttribute
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置关联的 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("related_global_sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("related_global_sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                                public string? RelatedSKUId { get; set; }

                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("id")]
                                [System.Text.Json.Serialization.JsonPropertyName("id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                                public string? SKUId { get; set; }

                                /// <summary>
                                /// 获取或设置卖家 SKU 信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_sku")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_sku")]
                                public string? SellerSKU { get; set; }

                                /// <summary>
                                /// 获取或设置销售属性列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_attributes")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_attributes")]
                                public List<Types.SalesAttribute>? SalesAttributeList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string? RegionCode { get; set; }

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public string? ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                        public string? ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public List<Types.SKU>? SKUList { get; set; }
                    }

                    public class PublishResult
                    {
                        public static class Types
                        {
                            public class FailReason
                            {
                                /// <summary>
                                /// 获取或设置错误信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("message")]
                                [System.Text.Json.Serialization.JsonPropertyName("message")]
                                public string? Message { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("region")]
                        [System.Text.Json.Serialization.JsonPropertyName("region")]
                        public string? RegionCode { get; set; }

                        /// <summary>
                        /// 获取或设置发布结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string? Status { get; set; }

                        /// <summary>
                        /// 获取或设置失败原因列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fail_reasons")]
                        [System.Text.Json.Serialization.JsonPropertyName("fail_reasons")]
                        public List<Types.FailReason>? FailReasonList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置产品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public List<Types.Product>? ProductList { get; set; }

                /// <summary>
                /// 获取或设置发布结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("publish_result")]
                [System.Text.Json.Serialization.JsonPropertyName("publish_result")]
                public List<Types.PublishResult>? PublishResultList { get; set; }
            }
        }
    }
}
