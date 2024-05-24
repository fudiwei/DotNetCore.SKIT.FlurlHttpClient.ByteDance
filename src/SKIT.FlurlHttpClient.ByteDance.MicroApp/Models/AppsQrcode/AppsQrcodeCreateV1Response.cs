namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/apps/v1/qrcode/create/ 接口的响应。</para>
    /// </summary>
    public class AppsQrcodeCreateV1Response : DouyinMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置经过 Base64 编码的二维码图片数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img")]
                [System.Text.Json.Serialization.JsonPropertyName("img")]
                public string EncodingImageData { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
