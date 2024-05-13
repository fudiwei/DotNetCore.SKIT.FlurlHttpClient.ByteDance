namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /customer_service/{version}/images/upload 接口的响应。</para>
    /// </summary>
    public class CustomerServiceUploadImageResponse : TikTokShopResponse<CustomerServiceUploadImageResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
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
            }
        }
    }
}
