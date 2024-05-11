namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/images/upload 接口的响应。</para>
    /// </summary>
    public class ProductUploadImageResponse : TikTokShopResponse<ProductUploadImageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置图片 URI。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uri")]
                [System.Text.Json.Serialization.JsonPropertyName("uri")]
                public string Uri { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;

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
                /// 获取或设置使用场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("use_case")]
                [System.Text.Json.Serialization.JsonPropertyName("use_case")]
                public string? UseCase { get; set; }
            }
        }
    }
}
