namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [POST] /2/file/video/ad 接口的响应。</para>
    /// </summary>
    public class FileVideoAdvertisingResponse : OceanEngineResponse<FileVideoAdvertisingResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置视频 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_id")]
                [System.Text.Json.Serialization.JsonPropertyName("video_id")]
                public string VideoId { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                public int Size { get; set; }

                /// <summary>
                /// 获取或设置视频宽度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("width")]
                [System.Text.Json.Serialization.JsonPropertyName("width")]
                public int Width { get; set; }

                /// <summary>
                /// 获取或设置视频高度（单位：像素）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("height")]
                [System.Text.Json.Serialization.JsonPropertyName("height")]
                public int Height { get; set; }

                /// <summary>
                /// 获取或设置视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_url")]
                [System.Text.Json.Serialization.JsonPropertyName("video_url")]
                public string VideoUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置视频时长（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duration")]
                [System.Text.Json.Serialization.JsonPropertyName("duration")]
                public decimal Duration { get; set; }

                /// <summary>
                /// 获取或设置视频格式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("format")]
                [System.Text.Json.Serialization.JsonPropertyName("format")]
                public string Format { get; set; } = default!;

                /// <summary>
                /// 获取或设置素材 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("material_id")]
                [System.Text.Json.Serialization.JsonPropertyName("material_id")]
                public long MaterialId { get; set; }

                /// <summary>
                /// 获取或设置视频 MD5 哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signature")]
                [System.Text.Json.Serialization.JsonPropertyName("signature")]
                public string Signature { get; set; } = default!;
            }
        }
    }
}
