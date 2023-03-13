namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /products/upload_imgs 接口的响应。</para>
    /// </summary>
    public class ProductUploadImageResponse : TikTokShopResponse<ProductUploadImageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_id")]
                [System.Text.Json.Serialization.JsonPropertyName("img_id")]
                public string ImageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片使用场景。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("img_scene")]
                public int Scene { get; set; }

                /// <summary>
                /// 获取或设置图片宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_width")]
                [System.Text.Json.Serialization.JsonPropertyName("img_width")]
                public int Width { get; set; }

                /// <summary>
                /// 获取或设置图片高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_height")]
                [System.Text.Json.Serialization.JsonPropertyName("img_height")]
                public int Height { get; set; }

                /// <summary>
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                public string ImageUrl { get; set; } = default!;
            }
        }
    }
}
