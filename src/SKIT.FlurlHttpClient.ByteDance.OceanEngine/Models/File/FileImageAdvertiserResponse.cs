namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/image/advertiser 接口的响应。</para>
    /// </summary>
    public class FileImageAdvertiserResponse : OceanEngineResponse<FileImageAdvertiserResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string ImageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int Size { get; set; }

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
                /// 获取或设置图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片格式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("format")]
                [System.Text.Json.Serialization.JsonPropertyName("format")]
                public string Format { get; set; } = default!;

                /// <summary>
                /// 获取或设置图片 MD5 哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signature")]
                [System.Text.Json.Serialization.JsonPropertyName("signature")]
                public string Signature { get; set; } = default!;
            }
        }
    }
}
