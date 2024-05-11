using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/global_categories/recommend 接口的请求。</para>
    /// </summary>
    public class ProductRecommendGlobalCategoriesRequest : TikTokShopRequest
    {
        public static class Types
        {
            public class Image
            {
                /// <summary>
                /// 获取或设置图片 URI。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uri")]
                [System.Text.Json.Serialization.JsonPropertyName("uri")]
                public string Uri { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_title")]
        [System.Text.Json.Serialization.JsonPropertyName("product_title")]
        public string ProductTitle { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public IList<Types.Image>? ImageList { get; set; }
    }
}
