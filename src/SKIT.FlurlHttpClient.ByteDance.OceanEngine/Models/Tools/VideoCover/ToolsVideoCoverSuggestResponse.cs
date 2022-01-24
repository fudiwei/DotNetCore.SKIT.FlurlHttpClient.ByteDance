namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/tools/video_cover/suggest 接口的响应。</para>
    /// </summary>
    public class ToolsVideoCoverSuggestResponse : OceanEngineResponse<ToolsVideoCoverSuggestResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Cover
                    {
                        /// <summary>
                        /// 获取或设置封面图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string ImageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置封面宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }

                        /// <summary>
                        /// 获取或设置封面高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置封面图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string ImageUrl { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置封面生成状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置封面列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Cover[]? CoverList { get; set; }
            }
        }
    }
}
