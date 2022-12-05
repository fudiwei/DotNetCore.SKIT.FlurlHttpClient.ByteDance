namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [GET] /goodlife/v1/goods/product/online/get 接口的响应。</para>
    /// </summary>
    public class GoodLifeGoodsProductOnlineGetV1Response : DouyinOpenResponse<GoodLifeGoodsProductOnlineGetV1Response.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResposneData
            {
                public static class Types
                {
                    public class ProductInfo : GoodLifeGoodsProductOnlineQueryV1Response.Types.Data.Types.ProductInfo
                    {
                        public static new class Types
                        {
                            public class Product : GoodLifeGoodsProductOnlineQueryV1Response.Types.Data.Types.ProductInfo.Types.Product
                            {
                                public static new class Types
                                {
                                    public class POI : GoodLifeGoodsProductOnlineQueryV1Response.Types.Data.Types.ProductInfo.Types.Product.Types.POI
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

                            public class SKU : GoodLifeGoodsProductOnlineQueryV1Response.Types.Data.Types.ProductInfo.Types.SKU
                            {
                                public static new class Types
                                {
                                    public class Stock : GoodLifeGoodsProductOnlineQueryV1Response.Types.Data.Types.ProductInfo.Types.SKU.Types.Stock
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

                            public class Commission : GoodLifeGoodsProductOnlineQueryV1Response.Types.Data.Types.ProductInfo.Types.Commission
                            {
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

                        /// <summary>
                        /// 获取或设置分佣信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                        public new Types.Commission? Commission { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_onlines")]
                [System.Text.Json.Serialization.JsonPropertyName("product_onlines")]
                public Types.ProductInfo[] ProductList { get; set; } = default!;
            }
        }
    }
}
