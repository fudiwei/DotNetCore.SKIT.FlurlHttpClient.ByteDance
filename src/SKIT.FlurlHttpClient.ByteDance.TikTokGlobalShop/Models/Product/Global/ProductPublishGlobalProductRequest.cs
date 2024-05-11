using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_products/{global_product_id}/publish 接口的请求。</para>
    /// </summary>
    public class ProductPublishGlobalProductRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class PublishTarget
            {
                public static class Types
                {
                    public class SKU
                    {
                        public static class Types
                        {
                            public class Price
                            {
                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置价格。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("amount")]
                                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                                public decimal Amount { get; set; }
                            }

                            public class Inventory
                            {
                                /// <summary>
                                /// 获取或设置仓库 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("warehouse_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("warehouse_id")]
                                public string WarehouseId { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置库存数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置关联的 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("related_global_sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("related_global_sku_id")]
                        public string RelatedSKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置价格信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public Types.Price? Price { get; set; }

                        /// <summary>
                        /// 获取或设置库存信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("inventory")]
                        [System.Text.Json.Serialization.JsonPropertyName("inventory")]
                        public Types.Inventory? Inventory { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置地区编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("region")]
                [System.Text.Json.Serialization.JsonPropertyName("region")]
                public string RegionCode { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public IList<Types.SKU>? SKUList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发布目标列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_target")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_target")]
        public IList<Types.PublishTarget>? PublishTargetList { get; set; }
    }
}
