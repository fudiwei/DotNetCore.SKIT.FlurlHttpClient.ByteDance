namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/images/optimize 接口的请求。</para>
    /// </summary>
    public class ProductOptimizeImagesRequest : TikTokShopRequest
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
                public string? Uri { get; set; }

                /// <summary>
                /// 获取或设置优化模式列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("optimization_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("optimization_mode")]
                public List<string>? OptimizationModeList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置 API 版本号。
        /// <para>默认值：202404</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override int ApiVersion { get; set; } = 202404;

        /// <summary>
        /// 获取或设置图片列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("images")]
        [System.Text.Json.Serialization.JsonPropertyName("images")]
        public List<Types.Image>? ImageList { get; set; }
    }
}
