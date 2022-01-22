namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /alliance/materialsProductsSearch 接口的响应。</para>
    /// </summary>
    public class AllianceMaterialsProductsSearchResponse : TikTokShopResponse<AllianceMaterialsProductsSearchResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public int ShopId { get; set; }

                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                        public string ShopName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                        public long ProductId { get; set; }

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品售价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置佣金比例（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cos_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("cos_ratio")]
                        public double COSRatio { get; set; }

                        /// <summary>
                        /// 获取或设置佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cos_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("cos_fee")]
                        public int COSFee { get; set; }

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
                        public int FirstCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
                        public int SecondCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
                        public int ThirdCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置是否有库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("in_stock")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("in_stock")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
                        public bool HasStock { get; set; }

                        /// <summary>
                        /// 获取或设置历史总销量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales")]
                        public int Sales { get; set; }

                        /// <summary>
                        /// 获取或设置商品封面 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cover")]
                        [System.Text.Json.Serialization.JsonPropertyName("cover")]
                        public string CoverUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置商品链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_url")]
                        public string DetailUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.Product[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int TotalCount { get; set; }
            }
        }
    }
}
