namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.ProductApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /modify 接口的请求。</para>
    /// </summary>
    public class ProductModifyRequest : DouyinMicroAppProductApiRequest
    {
        public static class Types
        {
            public class Product : ProductAddRequest.Types.Product
            {
                public new static class Types
                {
                    public class CommonProductInfo : ProductAddRequest.Types.Product.Types.CommonProductInfo
                    {
                        public new static class Types
                        {
                            public class PriceInfo : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.PriceInfo
                            {
                            }

                            public class PathInfo : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.PathInfo
                            {
                            }

                            public class ProductFulfilment : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductFulfilment
                            {
                                public new static class Types
                                {
                                    public class FulfillmentContent : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductFulfilment.Types.FulfillmentContent
                                    {
                                    }
                                }
                            }

                            public class ProductDetail : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductDetail
                            {
                                public new static class Types
                                {
                                    public class RichText : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.ProductDetail.Types.RichText
                                    {
                                    }
                                }
                            }

                            public class AnchorInfo : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.AnchorInfo
                            {
                                public new static class Types
                                {
                                    public class VideoAnchorInfo : ProductAddRequest.Types.Product.Types.CommonProductInfo.Types.AnchorInfo.Types.VideoAnchorInfo
                                    {
                                    }
                                }
                            }
                        }
                    }

                    public class CourseInfo : ProductAddRequest.Types.Product.Types.CourseInfo
                    {
                    }
                }
            }
        }

        /// <inheritdoc/>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

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
