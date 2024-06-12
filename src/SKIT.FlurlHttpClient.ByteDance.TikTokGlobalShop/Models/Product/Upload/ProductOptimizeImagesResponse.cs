namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/images/optimize 接口的响应。</para>
    /// </summary>
    public class ProductOptimizeImagesResponse : TikTokShopResponse<ProductOptimizeImagesResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {

                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置图片高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置原始图片 URI。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_uri")]
                        public string OriginalUri { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置原始图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("original_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("original_url")]
                        public string OriginalUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优化状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("optimize_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("optimize_status")]
                        public string OptimizeStatus { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置优化后图片 URI。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("optimized_uri")]
                        [System.Text.Json.Serialization.JsonPropertyName("optimized_uri")]
                        public string? OptimizedUri { get; set; }

                        /// <summary>
                        /// 获取或设置优化后图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("optimized_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("optimized_url")]
                        public string? OptimizedUrl { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("images")]
                [System.Text.Json.Serialization.JsonPropertyName("images")]
                public Types.Image[] ImageList { get; set; } = default!;
            }
        }
    }
}
