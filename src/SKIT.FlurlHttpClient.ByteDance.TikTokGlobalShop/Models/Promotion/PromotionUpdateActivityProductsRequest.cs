using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [PUT] /promotion/{version}/activities/{activity_id}/products 接口的请求。</para>
    /// </summary>
    public class PromotionUpdateActivityProductsRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置数量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity_limit")]
                        public int QuantityLimit { get; set; }

                        /// <summary>
                        /// 获取或设置单个用户数量限制。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity_per_user")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity_per_user")]
                        public int QuantityPerUser { get; set; }

                        /// <summary>
                        /// 获取或设置活动折扣（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        public int? Discount { get; set; }

                        /// <summary>
                        /// 获取或设置活动价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("activity_price_amount")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("activity_price_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public decimal? PriceAmount { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string ProductId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置数量限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity_limit")]
                public int QuantityLimit { get; set; }

                /// <summary>
                /// 获取或设置单个用户数量限制。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quantity_per_user")]
                [System.Text.Json.Serialization.JsonPropertyName("quantity_per_user")]
                public int QuantityPerUser { get; set; }

                /// <summary>
                /// 获取或设置活动折扣（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                public int? Discount { get; set; }

                /// <summary>
                /// 获取或设置活动价。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_price_amount")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("activity_price_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public decimal? PriceAmount { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public IList<Types.SKU> SKUList { get; set; } = new List<Types.SKU>();
            }
        }

        /// <summary>
        /// 获取或设置活动 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_id")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        public string ActivityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("products")]
        [System.Text.Json.Serialization.JsonPropertyName("products")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
