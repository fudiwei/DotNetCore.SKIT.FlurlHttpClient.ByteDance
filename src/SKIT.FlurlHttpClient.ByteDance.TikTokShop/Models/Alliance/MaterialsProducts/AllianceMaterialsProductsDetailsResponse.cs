namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /alliance/materialsProductsDetails 接口的响应。</para>
    /// </summary>
    public class AllianceMaterialsProductsDetailsResponse : TikTokShopResponse<AllianceMaterialsProductsDetailsResponse.Types.Data>
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
                            public class DailyStatistics
                            {
                                /// <summary>
                                /// 获取或设置日期字符串（格式：yyyyMMdd）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("date")]
                                [System.Text.Json.Serialization.JsonPropertyName("date")]
                                public string DateString { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置当天商品总订单量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_num")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int OrderCount { get; set; }

                                /// <summary>
                                /// 获取或设置当天商品总浏览量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("view_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("view_num")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int ViewCount { get; set; }

                                /// <summary>
                                /// 获取或设置当天推广总达人数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("kol_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("kol_num")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int KOLCount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
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
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
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
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Price { get; set; }

                        /// <summary>
                        /// 获取或设置佣金比例（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cos_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("cos_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public double COSRatio { get; set; }

                        /// <summary>
                        /// 获取或设置佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cos_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("cos_fee")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int COSFee { get; set; }

                        /// <summary>
                        /// 获取或设置达人佣金金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("kol_cos_fee")]
                        [System.Text.Json.Serialization.JsonPropertyName("kol_cos_fee")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int KOLCOSFee { get; set; }

                        /// <summary>
                        /// 获取或设置达人佣金比例（范围：0～100）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("kol_cos_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("kol_cos_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public double KOLCOSRatio { get; set; }

                        /// <summary>
                        /// 获取或设置一级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("first_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("first_cid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int FirstCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置二级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("second_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("second_cid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int SecondCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置三级类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("third_cid")]
                        [System.Text.Json.Serialization.JsonPropertyName("third_cid")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ThirdCategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置是否有库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("in_stock")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("in_stock")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualBooleanConverter))]
                        public bool HasStock { get; set; }

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

                        /// <summary>
                        /// 获取或设置历史总销量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int Sales { get; set; }

                        /// <summary>
                        /// 获取或设置商品评分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_score")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_score")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CommentScore { get; set; }

                        /// <summary>
                        /// 获取或设置商品评价数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment_num")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CommentCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 天商品总订单量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_num")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int OrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 天商品总浏览量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("view_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("view_num")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ViewCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 天推广总达人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("kol_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("kol_num")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int KOLCount { get; set; }

                        /// <summary>
                        /// 获取或设置每日统计数据列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("daily_statistics")]
                        [System.Text.Json.Serialization.JsonPropertyName("daily_statistics")]
                        public Types.DailyStatistics[] DailyStatisticsList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置活动审核状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置活动审核原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string? Reason { get; set; }

                        /// <summary>
                        /// 获取或设置专属团长功能活动对应的限制类目名称 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? CategoryId { get; set; }

                        /// <summary>
                        /// 获取或设置专属团长功能活动对应的限制类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string? CategoryName { get; set; }
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
