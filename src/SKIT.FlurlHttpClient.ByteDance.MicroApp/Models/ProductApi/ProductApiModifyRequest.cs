namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/modify 接口的请求。</para>
    /// </summary>
    public class ProductApiModifyRequest : ByteDanceMicroAppRequest
    {
        public static class Types
        {
            public class Product : ProductApiAddRequest.Types.Product
            {
                public new static class Types
                {
                    public class CommonProductInfo : ProductApiAddRequest.Types.Product.Types.CommonProductInfo
                    {
                        public new static class Types
                        {
                            public class PriceInfo : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.PriceInfo
                            {
                            }

                            public class PathInfo : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.PathInfo
                            {
                            }

                            public class ProductFulfilment : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductFulfilment
                            {
                                public new static class Types
                                {
                                    public class FulfillmentContent : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductFulfilment.Types.FulfillmentContent
                                    {
                                    }
                                }
                            }

                            public class ProductDetail : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductDetail
                            {
                                public new static class Types
                                {
                                    public class RichText : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductDetail.Types.RichText
                                    {
                                    }
                                }
                            }

                            public class AnchorInfo : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.AnchorInfo
                            {
                                public new static class Types
                                {
                                    public class VideoAnchorInfo : ProductApiAddRequest.Types.Product.Types.CommonProductInfo.Types.AnchorInfo.Types.VideoAnchorInfo
                                    {
                                    }
                                }
                            }
                        }
                    }

                    public class CourseInfo : ProductApiAddRequest.Types.Product.Types.CourseInfo
                    {
                    }
                }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public int ProductType { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = new Types.Product();
    }
}
