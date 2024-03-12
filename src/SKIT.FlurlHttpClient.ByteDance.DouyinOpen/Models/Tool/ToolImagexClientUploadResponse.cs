namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /tool/imagex/client_upload/ 接口的响应。</para>
    /// </summary>
    public class ToolImagexClientUploadResponse : DouyinOpenResponse<ToolImagexClientUploadResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
            }
        }

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

        /// <summary>
        /// 获取或设置图片 MD5 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("md5")]
        [System.Text.Json.Serialization.JsonPropertyName("md5")]
        public string Md5 { get; set; } = default!;
    }
}
