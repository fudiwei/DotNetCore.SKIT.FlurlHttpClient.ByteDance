namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /fulfillment/uploadimage 接口的请求。</para>
    /// </summary>
    public class FulfillmentUploadImageRequest : TikTokShopRequest
    {
        /// <summary>
        /// 获取或设置经 Base64 编码的图片内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_data")]
        [System.Text.Json.Serialization.JsonPropertyName("img_data")]
        public string EncodingImageData { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置图片使用场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("img_scene")]
        public int Scene { get; set; }
    }
}
