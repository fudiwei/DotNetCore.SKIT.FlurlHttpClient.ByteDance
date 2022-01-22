namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/file/image/ad/get 接口的响应。</para>
    /// </summary>
    public class FileImageAdvertiserGetResponse : OceanEngineResponse<FileImageAdvertiserGetResponse.Types.Data>
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
                        /// <summary>
                        /// 获取或设置素材 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("material_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("material_id")]
                        public long MaterialId { get; set; }
                    }

                    public class Pagination : AgentAdvertiserSelectResponse.Types.Data.Types.Pagination
                    {
                    }
                }

                /// <summary>
                /// 获取或设置图片列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Image[] ImageList { get; set; } = default!;

                /// <summary>
                /// 获取或设置分页信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_info")]
                [System.Text.Json.Serialization.JsonPropertyName("page_info")]
                public Types.Pagination Pagination { get; set; } = default!;
            }
        }
    }
}
