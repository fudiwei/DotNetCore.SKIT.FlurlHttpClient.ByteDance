namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /image/upload 接口的响应。</para>
    /// </summary>
    public class ImageUploadResponse : DouyinOpenResponse<ImageUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Image
                    {
                        /// <summary>
                        /// 获取或设置图片 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("image_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("image_id")]
                        public string ImageId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置图片高度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("height")]
                        [System.Text.Json.Serialization.JsonPropertyName("height")]
                        public int Height { get; set; }

                        /// <summary>
                        /// 获取或设置图片宽度（单位：像素）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("width")]
                        [System.Text.Json.Serialization.JsonPropertyName("width")]
                        public int Width { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置图片信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public Types.Image Image { get; set; } = default!;
            }
        }
    }
}
