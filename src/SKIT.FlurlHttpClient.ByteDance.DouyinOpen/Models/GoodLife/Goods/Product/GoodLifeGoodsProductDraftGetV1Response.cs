namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/product/draft/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsProductDraftGetV1Response : DouyinOpenResponse<GoodLifeGoodsProductDraftGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class ProductDraft : GoodLifeGoodsProductDraftQueryV1Response.Types.Data.Types.ProductDraft
                    {
                        public static new class Types
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
                                public new Types.POI[] POIList { get; set; } = default!;
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
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product")]
                        [System.Text.Json.Serialization.JsonPropertyName("product")]
                        public new Types.Product Product { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku")]
                        public new Types.SKU? SKU { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置草稿列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_drafts")]
                [System.Text.Json.Serialization.JsonPropertyName("product_drafts")]
                public Types.ProductDraft[] DraftList { get; set; } = default!;
            }
        }
    }
}
