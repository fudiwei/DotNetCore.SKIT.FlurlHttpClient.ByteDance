namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/product/online/query 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsProductOnlineQueryV1Response : DouyinOpenResponse<GoodLifeGoodsProductOnlineQueryV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class ProductInfo
                    {
                        public static class Types
                        {
                            public class Product : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft.Types.Product
                            {
                                public static new class Types
                                {
                                    public class POI : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft.Types.Product.Types.POI
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置门店列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pois")]
                                [System.Text.Json.Serialization.JsonPropertyName("pois")]
                                public new Types.POI[]? POIList { get; set; }

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }

                            public class SKU : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft.Types.SKU
                            {
                                public static new class Types
                                {
                                    public class Stock : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft.Types.SKU.Types.Stock
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置库存信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("stock")]
                                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                                public new Types.Stock Stock { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }

                            public class Commission
                            {
                                /// <summary>
                                /// 获取或设置平台分佣率（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_take_rate")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_take_rate")]
                                public double PlatformTakeRate { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置上线状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("online_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("online_status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product")]
                        [System.Text.Json.Serialization.JsonPropertyName("product")]
                        public Types.Product Product { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public Types.SKU? SKU { get; set; }

                        /// <summary>
                        /// 获取或设置分佣信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                        public Types.Commission? Commission { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("products")]
                [System.Text.Json.Serialization.JsonPropertyName("products")]
                public Types.ProductInfo[] ProductList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页游标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("next_cursor")]
                [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
                public string? PageCursor { get; set; }

                /// <summary>
                /// 获取或设置是否还有更多。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_more")]
                [System.Text.Json.Serialization.JsonPropertyName("has_more")]
                public bool HasMore { get; set; }
            }
        }
    }
}
