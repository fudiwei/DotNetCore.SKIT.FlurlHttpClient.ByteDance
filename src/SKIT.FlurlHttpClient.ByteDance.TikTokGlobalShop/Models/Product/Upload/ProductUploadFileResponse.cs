namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/{version}/files/upload 接口的响应。</para>
    /// </summary>
    public class ProductUploadFileResponse : TikTokShopResponse<ProductUploadFileResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string FileId { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件格式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("format")]
                [System.Text.Json.Serialization.JsonPropertyName("format")]
                public string Format { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string Url { get; set; } = default!;
            }
        }
    }
}
