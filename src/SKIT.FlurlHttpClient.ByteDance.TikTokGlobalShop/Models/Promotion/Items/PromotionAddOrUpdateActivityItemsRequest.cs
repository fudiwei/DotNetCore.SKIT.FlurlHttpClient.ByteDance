using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /promotion/activity/items/addorupdate 接口的请求。</para>
    /// </summary>
    public class PromotionAddOrUpdateActivityItemsRequest : TikTokShopRequest
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
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public string ProductId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public string SKUId { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置促销价格。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_price")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? PromotionPrice { get; set; }

                        /// <summary>
                        /// 获取或设置折扣比例（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? Discount { get; set; }

                        /// <summary>
                        /// 获取或设置库存上限。
                        /// <para>默认值：-1</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("num_limit")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int StockLimit { get; set; } = -1;

                        /// <summary>
                        /// 获取或设置用户使用上限。
                        /// <para>默认值：-1</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_limit")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int UserLimit { get; set; } = -1;
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                public string ProductId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置促销价格。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promotion_price")]
                [System.Text.Json.Serialization.JsonPropertyName("promotion_price")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal? PromotionPrice { get; set; }

                /// <summary>
                /// 获取或设置折扣比例（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("discount")]
                [System.Text.Json.Serialization.JsonPropertyName("discount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal? Discount { get; set; }

                /// <summary>
                /// 获取或设置库存上限。
                /// <para>默认值：-1</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("num_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("num_limit")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int StockLimit { get; set; } = -1;

                /// <summary>
                /// 获取或设置用户使用上限。
                /// <para>默认值：-1</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_limit")]
                [System.Text.Json.Serialization.JsonPropertyName("user_limit")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int UserLimit { get; set; } = -1;

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
                public IList<Types.SKU>? SKUList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置请求序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_serial_no")]
        [System.Text.Json.Serialization.JsonPropertyName("request_serial_no")]
        public string RequestSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置促销 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_id")]
        public string PromotionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public IList<Types.Product> ProductList { get; set; } = new List<Types.Product>();
    }
}
